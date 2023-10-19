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

	#region Class: NavProcessPaymentScheduleUserTask

	[DesignModeProperty(Name = "AgreementId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.AgreementId.Caption", DescriptionResourceItem = "Parameters.AgreementId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NavCreditAmount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.NavCreditAmount.Caption", DescriptionResourceItem = "Parameters.NavCreditAmount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NavCreditPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.NavCreditPeriod.Caption", DescriptionResourceItem = "Parameters.NavCreditPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NavDate", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.NavDate.Caption", DescriptionResourceItem = "Parameters.NavDate.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TypeInvoice", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.TypeInvoice.Caption", DescriptionResourceItem = "Parameters.TypeInvoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NavName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0265856fd6e447686130a26519635e2", CaptionResourceItem = "Parameters.NavName.Caption", DescriptionResourceItem = "Parameters.NavName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class NavProcessPaymentScheduleUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public NavProcessPaymentScheduleUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b0265856-fd6e-4476-8613-0a26519635e2");
		}

		#endregion

		#region Properties: Public

		public virtual Guid AgreementId {
			get;
			set;
		}

		public virtual Decimal NavCreditAmount {
			get;
			set;
		}

		public virtual int NavCreditPeriod {
			get;
			set;
		}

		public virtual DateTime NavDate {
			get;
			set;
		}

		public virtual Guid TypeInvoice {
			get;
			set;
		}

		public virtual string NavName {
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
			if (!HasMapping("AgreementId")) {
				writer.WriteValue("AgreementId", AgreementId, Guid.Empty);
			}
			if (!HasMapping("NavCreditAmount")) {
				writer.WriteValue("NavCreditAmount", NavCreditAmount, 0m);
			}
			if (!HasMapping("NavCreditPeriod")) {
				writer.WriteValue("NavCreditPeriod", NavCreditPeriod, 0);
			}
			if (!HasMapping("NavDate")) {
				writer.WriteValue("NavDate", NavDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("TypeInvoice")) {
				writer.WriteValue("TypeInvoice", TypeInvoice, Guid.Empty);
			}
			if (!HasMapping("NavName")) {
				writer.WriteValue("NavName", NavName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "AgreementId":
					AgreementId = reader.GetGuidValue();
				break;
				case "NavCreditAmount":
					NavCreditAmount = reader.GetValue<System.Decimal>();
				break;
				case "NavCreditPeriod":
					NavCreditPeriod = reader.GetIntValue();
				break;
				case "NavDate":
					NavDate = reader.GetDateTimeValue();
				break;
				case "TypeInvoice":
					TypeInvoice = reader.GetGuidValue();
				break;
				case "NavName":
					NavName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

