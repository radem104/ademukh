using System;
using Terrasoft.Configuration;
using Terrasoft.Core;
using Terrasoft.Core.DB;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

[EntityEventListener(SchemaName = "NavAgreement")]
public class AgreementEntityEventListener : BaseEntityEventListener
{
    public override void OnSaving(object sender, EntityBeforeEventArgs e)
    {       
        var entity = (NavAgreement)sender;
        var userConnection = entity.UserConnection;
        GetInfoForContact(userConnection, entity);
        ÑheckingEquivalenceAmount(userConnection, entity);
        base.OnSaving(sender, e);
    }

    private void GetInfoForContact(UserConnection userConnection, NavAgreement entity)
    {
        var contactValue = entity.NavContactId;
        var contact = new EntitySchemaQuery(userConnection.EntitySchemaManager.GetInstanceByName("Contact"));
        var firstAgreement = contact.AddColumn("NavFirstAgreement").Name;
        contact.PrimaryQueryColumn.IsAlwaysSelect = true;
        contact.AddAllSchemaColumns();
        var contacFilter = contact.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", contactValue);
        contact.Filters.Add(contacFilter);
        var result = contact.GetEntityCollection(userConnection);
        foreach(var p in result)
        {
            var agreement = p.GetTypedColumnValue<DateTime>(firstAgreement);
            if (agreement == new DateTime())
            {
                SetFirstAgreement(userConnection, entity);
            }
        }

    }

    private void SetFirstAgreement(UserConnection userConnection, NavAgreement entity) 
    {
        var schema = userConnection.EntitySchemaManager.GetInstanceByName("Contact");
        var contactShema = schema.CreateEntity(userConnection);
        contactShema.SetColumnValue("NavFirstAgreement", entity.NavDate);
    }

    private void ÑheckingEquivalenceAmount(UserConnection userConnection, NavAgreement entity)
    {
        if(entity.NavSumma == entity.NavFactSumma)
        {
            var schema = userConnection.EntitySchemaManager.GetInstanceByName("NavInvoice");
            var invoiceShema = schema.CreateEntity(userConnection);
            bool valueFactSum = true;
            invoiceShema.SetColumnValue("NavFact", valueFactSum);
            invoiceShema.Save();
        }
    }
}