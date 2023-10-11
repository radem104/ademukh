namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NavAgreementCodeSchema

	/// <exclude/>
	public class NavAgreementCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NavAgreementCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NavAgreementCodeSchema(NavAgreementCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4cef4c73-e208-4d38-a8f4-7dca5d604d70");
			Name = "NavAgreementCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b6669bb-54ad-4463-9cb0-ec242f887ff8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,205,106,227,48,16,190,27,252,14,106,78,54,20,61,192,134,30,106,167,41,129,110,123,200,238,94,74,15,138,60,113,85,98,105,209,143,33,44,125,247,29,217,78,45,37,10,213,41,154,249,252,253,204,136,56,35,100,75,182,71,99,161,91,230,153,27,174,191,64,107,102,212,222,210,90,201,189,104,157,102,86,40,153,236,107,184,82,166,171,234,90,231,65,90,97,5,152,239,250,244,161,7,105,61,44,207,94,135,226,113,168,60,9,180,43,65,23,91,254,14,29,123,102,29,144,59,178,120,102,253,125,171,1,58,132,44,202,183,60,251,235,118,7,193,9,63,48,99,200,87,43,65,68,126,144,138,25,72,116,242,236,95,158,17,60,19,151,234,209,170,104,128,244,74,52,228,69,110,89,143,1,10,181,251,0,110,137,1,217,128,190,37,35,81,5,123,76,51,208,221,235,214,16,40,71,170,137,209,159,29,170,210,23,185,145,6,180,245,68,39,6,40,151,51,170,103,154,192,64,137,49,139,48,102,57,226,3,236,163,67,95,92,73,203,184,173,157,214,8,58,99,114,168,133,123,149,104,24,151,138,140,35,53,253,29,213,131,143,196,158,20,19,6,181,235,145,155,174,193,242,247,181,86,221,170,186,236,110,154,178,156,9,130,192,254,196,238,102,3,1,249,166,89,198,223,140,19,29,247,125,34,152,110,119,103,137,104,136,253,201,36,107,65,211,71,176,56,100,203,36,135,234,232,31,76,177,152,180,22,101,82,234,36,130,244,145,28,173,53,48,59,61,149,34,86,62,103,242,131,227,137,113,197,3,8,39,149,152,150,63,211,243,106,80,120,45,180,177,95,251,159,221,249,132,181,58,184,78,254,97,7,135,241,112,154,49,246,34,232,201,226,77,202,227,165,214,185,207,43,94,131,13,211,237,183,158,110,131,229,175,80,50,229,49,98,100,61,20,41,208,103,92,10,174,243,79,255,63,50,85,62,255,3,174,95,129,139,249,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4cef4c73-e208-4d38-a8f4-7dca5d604d70"));
		}

		#endregion

	}

	#endregion

}

