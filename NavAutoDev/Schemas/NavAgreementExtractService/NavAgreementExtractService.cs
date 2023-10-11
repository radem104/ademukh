using NavAutoDev;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Terrasoft.Configuration;
using Terrasoft.Core.Entities;
using Terrasoft.Web.Http.Abstractions;

[System.ServiceModel.ServiceContract]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
public class NavAgreementExtractService : Terrasoft.Web.Common.BaseService
{
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
        ResponseFormat = WebMessageFormat.Json)]
    public string GetInfoAgreementById(string Id)
    {
        var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "NavAgreement");
        esq.PrimaryQueryColumn.IsAlwaysSelect = true;
        esq.AddAllSchemaColumns();
        var nameAgreement = esq.AddColumn("NavName");
        var autoBrandName = esq.AddColumn("NavAuto.NavBrand.NavName");
        var autoModelName = esq.AddColumn("NavAuto.NavModel.NavName");
        var autoDetails = esq.AddColumn("NavAuto.NavDetails");
        var autoVin = esq.AddColumn("NavAuto.NavVin");
        var contactName = esq.AddColumn("NavContact.Name");
        var summa = esq.AddColumn("NavSumma");
        var factSumma = esq.AddColumn("NavFactSumma");
        var fact = esq.AddColumn("NavFact");

        var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Guid.Parse(Id));
        esq.Filters.Add(esqFilter);
        var entities = esq.GetEntityCollection(UserConnection);
        var contract = new NavAutoDev.Contract();
        if (entities.Count > 0)
        {
            foreach(var item in entities)
            {
                contract = new NavAutoDev.Contract()
                {
                    Number = item.GetColumnValue(nameAgreement.Name).ToString(),
                    Auto = new List<Auto>()
                    {
                       new Auto
                       {
                           Brand = item.GetColumnValue(autoBrandName.Name).ToString(),
                           Model = item.GetColumnValue(autoModelName.Name).ToString(),
                           Details = item.GetColumnValue(autoDetails.Name).ToString(),
                           VIN = item.GetColumnValue(autoVin.Name).ToString(),
                       }
                    },
                    Contact = new List<NavAutoDev.Contact>
                    {
                        new NavAutoDev.Contact
                        {
                            FullName = item.GetColumnValue(contactName.Name).ToString(),
                        }
                    },
                    Summa = item.GetColumnValue(summa.Name).ToString(),
                    FactSumma = item.GetColumnValue(factSumma.Name).ToString(),
                    Fact = item.GetColumnValue(fact.Name).ToString(),
                };        
            }
        }
        contract = GetInfoInvoice(Guid.Parse(Id), contract);
        var json = JsonConvert.SerializeObject(contract, Formatting.Indented);
        //byte[] byteArray = Encoding.UTF8.GetBytes(json);
        return json;
    }
    public NavAutoDev.Contract GetInfoInvoice(Guid id, NavAutoDev.Contract contract)
    {
        var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "NavInvoice");
        esq.PrimaryQueryColumn.IsAlwaysSelect = true;
        esq.AddAllSchemaColumns();
        var invoiceName = esq.AddColumn("NavName");
        var dateInvoice = esq.AddColumn("NavDate");
        var amountInvoice = esq.AddColumn("NavAmount");
        var factInvoice = esq.AddColumn("NavFact");
        var typeNameInvoice = esq.AddColumn("NavInvoiceType.Name");
        var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "NavAgreement", id);
        esq.Filters.Add(esqFilter);
        var entities = esq.GetEntityCollection(UserConnection);
        if (entities.Count > 0)
        {
            foreach (var item in entities)
            {
                contract.Invoices = new List<NavAutoDev.Invoice>
                {
                    new NavAutoDev.Invoice
                    {
                        Number = item.GetTypedColumnValue<string>(invoiceName.Name).ToString(),
                        Date = item.GetTypedColumnValue<DateTime>(dateInvoice.Name).ToString(),
                        Amount = item.GetTypedColumnValue<float>(amountInvoice.Name).ToString(),
                        Fact = item.GetTypedColumnValue<bool>(factInvoice.Name).ToString(),
                        TypeNameInvoice = item.GetTypedColumnValue<string>(typeNameInvoice.Name).ToString(),
                    }
                };              
            }
        }
        return contract;

    }
}