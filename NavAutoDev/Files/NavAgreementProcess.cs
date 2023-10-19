using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terrasoft.Core;
using Terrasoft.Core.DB;
using Terrasoft.Core.Entities;

namespace NavAutoDev
{
    public class NavAgreementProcess
    {
        private UserConnection userConnection { get; set; }
        public NavAgreementProcess(UserConnection userConnection)
        {
            this.userConnection = userConnection;
        }

        public bool CreateInvoice(Guid agreementId, string name)
        {
            var schema = userConnection.EntitySchemaManager.GetInstanceByName("NavInvoice");
            var navShema = schema.CreateEntity(userConnection);
            navShema.SetDefColumnValues();
            navShema.SetColumnValue("Id", Guid.NewGuid());
            navShema.SetColumnValue("NavAgreementId", agreementId);
            navShema.SetColumnValue("NavName", $"Счет для {name}");
            navShema.Save();
            return true;
        }

        public bool DeleteInvoice(Guid agreementId, Guid typeInvoice)
        {
            //var delete = new Delete(userConnection)
            //    .From("NavInvoice")
            //    .Where("NavAgreementId").IsEqual(Column.Parameter(agreementId))
            //    .And("NavInvoiceTypeId").IsEqual(Column.Parameter(typeInvoice));
            //delete.Execute();
            return true;

          
        }

        public void CreatePayment(Guid agreementId, string nameAgreement, DateTime dateAgreement, int creditPeriod, decimal summaCredit, Guid typeInvoice)
        {          
            int valueMounth = 0;
            var summaInvoice = summaCredit / creditPeriod*12;
            for (int i = 0; i <= creditPeriod*12; i++)
            {
                var schema = userConnection.EntitySchemaManager.GetInstanceByName("NavInvoice");
                var navShema = schema.CreateEntity(userConnection);
                navShema.SetDefColumnValues();
                navShema.SetColumnValue("Id", Guid.NewGuid());
                navShema.SetColumnValue("NavAgreementId", agreementId);
                navShema.SetColumnValue("NavName", $"Счет для {nameAgreement}");
                var payDate = dateAgreement.AddMonths(valueMounth);
                navShema.SetColumnValue("NavPayDate", payDate);
                valueMounth++;
                navShema.SetColumnValue("NavAmount", summaInvoice);
                navShema.SetColumnValue("NavInvoiceTypeId", typeInvoice);
                navShema.Save();
            }
            
        }

    }
    }

