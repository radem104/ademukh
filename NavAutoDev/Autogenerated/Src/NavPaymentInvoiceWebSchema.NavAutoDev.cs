namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavPaymentInvoiceWebSchema

	/// <exclude/>
	public class NavPaymentInvoiceWebSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavPaymentInvoiceWebSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavPaymentInvoiceWebSchema(NavPaymentInvoiceWebSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f52f0851-8f2f-4fd8-a6f0-d8245e13609d");
			Name = "NavPaymentInvoiceWeb";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a97974eb-06c4-4898-9412-b17c7e2298f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,45,206,204,75,87,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,179,230,42,69,147,14,79,77,210,243,40,41,41,208,115,76,42,46,41,74,76,6,169,42,182,230,2,0,46,224,131,105,70,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f52f0851-8f2f-4fd8-a6f0-d8245e13609d"));
		}

		#endregion

	}

	#endregion

}

