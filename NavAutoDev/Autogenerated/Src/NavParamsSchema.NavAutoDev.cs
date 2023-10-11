namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavParamsSchema

	/// <exclude/>
	public class NavParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavParamsSchema(NavParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("814ee371-df8a-4cf7-9229-9bb6dbd4e0e3");
			Name = "NavParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b6669bb-54ad-4463-9cb0-ec242f887ff8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,76,203,10,131,64,12,188,47,236,63,228,11,10,158,75,79,254,64,161,254,64,220,70,9,232,70,146,108,65,164,255,222,232,173,51,204,97,30,76,51,174,51,188,118,115,90,239,57,181,203,14,164,138,38,147,223,122,169,19,207,77,209,89,106,244,39,183,54,46,92,192,60,194,2,101,65,51,120,162,226,74,78,106,57,29,57,65,224,127,198,213,67,31,225,66,195,190,81,47,111,130,7,116,113,249,61,63,127,31,21,159,121,135,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("814ee371-df8a-4cf7-9229-9bb6dbd4e0e3"));
		}

		#endregion

	}

	#endregion

}

