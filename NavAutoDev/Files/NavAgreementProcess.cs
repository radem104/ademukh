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
    class NavAgreementProcess
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

        public bool DeleteInvoice(Guid agreementId, int typeInvoice)
        {
            //var delete = new Delete(userConnection)
            //    .From("NavInvoice")
            //    .Where("NavAgreementId").IsEqual(Column.Parameter(agreementId))
            //    .And("NavInvoiceTypeId").IsEqual(Column.Parameter(typeInvoice));
            //delete.Execute();

            //var schema = userConnection.EntitySchemaManager.GetInstanceByName("NavInvoice");
            //var navShema = schema.CreateEntity(userConnection);
            //navShema.SetDefColumnValues();
            //navShema.SetColumnValue("Id", Guid.NewGuid());
            //navShema.SetColumnValue("NavAgreementId", agreementId);
            //navShema.SetColumnValue("NavName", $"Счет для {name}");
            //navShema.Save();
            return true;
        }


    }
    }

