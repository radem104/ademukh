using System;
using Terrasoft.Configuration;
using Terrasoft.Core;
using Terrasoft.Core.DB;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

[EntityEventListener(SchemaName = "NavInvoice")]
public class InvoiceEntityEventListener : BaseEntityEventListener
{
    private bool IsEmpty(NavInvoice entity)
    {
        if (entity.NavInvoiceType.FetchFromDB(entity.NavInvoiceTypeId))
        {
            return false;
        }
        else
        {
            return true;
        }        
    }
    /// <summary>
    /// <see cref="BaseEntityEventListener.OnInserting"/>.
    /// </summary>
    public override void OnInserting(object sender, EntityBeforeEventArgs e)
    {
        base.OnInserting(sender, e);
        var entity = (NavInvoice)sender;
        var userConnection = entity.UserConnection;
        NavInvoiceType invoiceType = GetInvoiceTypeName(Parameters.invoiceTypeCode, userConnection);
        
        if (IsEmpty(entity) == true)
        {
            SaveInvoiceType(entity, invoiceType);
        }
        if (entity.NavFact == true)
        {
            InvoiceAmountEntityEventListener invoice = new InvoiceAmountEntityEventListener();
            invoice.SetSumAmountAgreement(userConnection, entity);
        }
        bool checkDates = ÑheckingDates(userConnection, entity);
        if (checkDates) { 
            bool checkOldNavDates = CheckOldNavDateInvoice(userConnection, entity);
            if (checkOldNavDates)
            {
                throw new Exception("Ñîçäàâàòü áîëåå îäíîãî ñ÷åòà íà îäíó è òó æå äàòó êàê ó äîãîâîðà íåëüçÿ");
            }
        }
    }
    private void SaveInvoiceType(NavInvoice entity, NavInvoiceType nameInvoice)
    {
        entity.SetColumnValue("NavInvoiceTypeId", nameInvoice.Id);
        entity.Save();
    }

    private NavInvoiceType GetInvoiceTypeName(int invoiceTypeCode, UserConnection userConnection)
    {
        var invoiceESQ = new EntitySchemaQuery(userConnection.EntitySchemaManager, "NavInvoiceType");
        invoiceESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
        invoiceESQ.AddAllSchemaColumns();
        var invoiceFilter = invoiceESQ.CreateFilterWithParameters(
                FilterComparisonType.Equal, "NavCode", invoiceTypeCode);
        invoiceESQ.Filters.Add(invoiceFilter);
        var result = invoiceESQ.GetEntityCollection(userConnection)[0];
        return (NavInvoiceType)result;
    }

    private bool ÑheckingDates(UserConnection userConnection, NavInvoice entity)
    {
        var agreement = new EntitySchemaQuery(userConnection.EntitySchemaManager, "NavAgreement");
        agreement.PrimaryQueryColumn.IsAlwaysSelect = true;
        agreement.AddAllSchemaColumns();
        var agreementFilter = agreement.CreateFilterWithParameters(
                FilterComparisonType.Equal, "Id", entity.NavAgreementId);
        agreement.Filters.Add(agreementFilter);
        var agreementResult = (NavAgreement)agreement.GetEntityCollection(userConnection)[0];
        if(agreementResult.NavDate == entity.NavDate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool CheckOldNavDateInvoice(UserConnection userConnection, NavInvoice entity)
    {
        var invoice = new EntitySchemaQuery(userConnection.EntitySchemaManager, "NavInvoice");
        invoice.PrimaryQueryColumn.IsAlwaysSelect = true;
        invoice.AddAllSchemaColumns();
        var agreementFilter = invoice.CreateFilterWithParameters(
                FilterComparisonType.Equal, "NavDate", entity.NavDate);
        invoice.Filters.Add(agreementFilter);
        var invoiceResult = invoice.GetEntityCollection(userConnection);
        if(invoiceResult.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

