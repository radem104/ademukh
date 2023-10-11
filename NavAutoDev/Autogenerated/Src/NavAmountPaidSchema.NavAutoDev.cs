namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavAmountPaidSchema

	/// <exclude/>
	public class NavAmountPaidSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavAmountPaidSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavAmountPaidSchema(NavAmountPaidSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62100642-2217-469e-afe5-2edfa024015c");
			Name = "NavAmountPaid";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a97974eb-06c4-4898-9412-b17c7e2298f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,0,0,69,207,108,233,1,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62100642-2217-469e-afe5-2edfa024015c"));
		}

		#endregion

	}

	#endregion

}

