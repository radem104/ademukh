using System;
using Terrasoft.Configuration;
using Terrasoft.Core;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

[EntityEventListener(SchemaName = "NavInvoice")]
public class InvoiceAmountEntityEventListener : BaseEntityEventListener
{
    public override void OnSaved(object sender, EntityAfterEventArgs e)
    {
        base.OnSaved(sender, e);
        var entity = (NavInvoice)sender;
        var userConnection = entity.UserConnection;
        bool exceptionExceeding = false;
        if (entity.NavFact == true)
        {
            exceptionExceeding = IsExceedingSum(userConnection, entity);
            entity.NavPayDate = DateTime.Now;
        }
        if(exceptionExceeding == true)
        {
            throw new Exception("Сумма на счету превышает общую сумму в договоре!");
        }
    }
    public override void OnUpdated(object sender, EntityAfterEventArgs e)
    {
        base.OnUpdated(sender, e);
        var entity = (NavInvoice)sender;
        var userConnection = entity.UserConnection;
        bool exceptionExceeding = false;
        if (entity.NavFact == true)
        {
            exceptionExceeding = IsExceedingSum(userConnection, entity);
        }
        if (exceptionExceeding == true)
        {
            throw new Exception("Сумма на счету превышает общую сумму в договоре!");
        }
    }
    public override void OnUpdating(object sender, EntityBeforeEventArgs e)
    {
        base.OnUpdating(sender, e);
        var entity = (NavInvoice)sender;
        var userConnection = entity.UserConnection;
        var oldValue = entity.GetColumnOldValue("NavFact").ToString();
        var currentValue = entity.NavFact.ToString();
        if (oldValue != currentValue)
        {
            SetSumAmountAgreement(userConnection, entity);
        }
    }

    public override void OnDeleting(object sender, EntityBeforeEventArgs e)
    {
        base.OnDeleting(sender, e);
        var entity = (NavInvoice)sender;
        var userConnection = entity.UserConnection;
        if (entity.NavFact == true)
        {
            SetSumAmountAgreement(userConnection, entity);
        }
    }

    public bool SetSumAmountAgreement(UserConnection userConnection, NavInvoice entity)
    {
        var schema = userConnection.EntitySchemaManager.GetInstanceByName("NavAgreement");
        var contactShema = schema.CreateEntity(userConnection);
        contactShema.SetColumnValue("NavFactSumma", entity.NavAmount);
        contactShema.Save();
        return true;
    }

    private bool IsExceedingSum(UserConnection userConnection, NavInvoice entity)
    {
        var agreement = new EntitySchemaQuery(userConnection.EntitySchemaManager.GetInstanceByName("NavAgreement"));
        var summa = agreement.AddColumn("NavSumma").Name;
        agreement.PrimaryQueryColumn.IsAlwaysSelect = true;
        agreement.AddAllSchemaColumns();
        var contacFilter = agreement.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", entity.NavAgreementId);
        agreement.Filters.Add(contacFilter);
        var navSumma = agreement.GetEntityCollection(userConnection)[0].GetTypedColumnValue<Decimal>("NavSumma");
        if(entity.NavAmount <= navSumma)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}