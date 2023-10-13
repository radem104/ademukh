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

	[DesignModeProperty(Name = "NavEmail", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3989ded4e6f74580939d1f79474b57b0", CaptionResourceItem = "Parameters.NavEmail.Caption", DescriptionResourceItem = "Parameters.NavEmail.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class NavAgreementProcessUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public NavAgreementProcessUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("3989ded4-e6f7-4580-939d-1f79474b57b0");
		}

		#endregion

		#region Properties: Public

		public virtual string NavEmail {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("NavEmail")) {
				writer.WriteValue("NavEmail", NavEmail, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "NavEmail":
					NavEmail = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

