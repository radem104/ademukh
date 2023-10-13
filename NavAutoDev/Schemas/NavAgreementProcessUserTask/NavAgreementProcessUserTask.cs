namespace Terrasoft.Core.Process.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: NavAgreementProcessUserTask

	/// <exclude/>
	public partial class NavAgreementProcessUserTask
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityType");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns();
			var Id = esq.AddColumn("Id");
			var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Name", NavEmail);
			esq.Filters.Add(esqFilter);
			var entities = esq.GetEntityCollection(UserConnection);
			Guid id = Guid.Empty;
			foreach (var item in entities)
			{
				id = item.GetTypedColumnValue<Guid>(Id.Name);
			}
			if(id != Guid.Empty)
            {
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("Activity");
				var contactShema = schema.CreateEntity(UserConnection);
				contactShema.SetDefColumnValues();
				contactShema.SetColumnValue("Id", Guid.NewGuid());
				contactShema.SetColumnValue("TypeId", id);
				contactShema.Save();
			}
				return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		#endregion

	}

	#endregion

}

