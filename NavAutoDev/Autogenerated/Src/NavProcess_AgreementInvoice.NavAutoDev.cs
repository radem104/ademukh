namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: NavProcess_AgreementInvoiceMethodsWrapper

	/// <exclude/>
	public class NavProcess_AgreementInvoiceMethodsWrapper : ProcessModel
	{

		public NavProcess_AgreementInvoiceMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var agreementId = Get<Guid>("AgreementId");
			var name = Get<string>("NavNameAgreement");
			NavAutoDev.NavAgreementProcess nav = new NavAutoDev.NavAgreementProcess(UserConnection);
			nav.CreateInvoice(agreementId, name);
			return true;
		}

		#endregion

	}

	#endregion

}

