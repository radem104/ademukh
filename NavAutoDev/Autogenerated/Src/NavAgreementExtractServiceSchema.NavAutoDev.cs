namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavAgreementExtractServiceSchema

	/// <exclude/>
	public class NavAgreementExtractServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavAgreementExtractServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavAgreementExtractServiceSchema(NavAgreementExtractServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b69bd3e-a7e0-469e-abe9-a354dcce52d8");
			Name = "NavAgreementExtractService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a97974eb-06c4-4898-9412-b17c7e2298f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,0,0,69,207,108,233,1,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b69bd3e-a7e0-469e-abe9-a354dcce52d8"));
		}

		#endregion

	}

	#endregion

}

