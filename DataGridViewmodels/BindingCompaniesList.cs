using System.Collections.Generic;

namespace WindowsFormsCompaniesManager.DataGridViewmodels
{
	class BindingCompaniesList : CustomBindingList<BindingCompany>
	{
		public BindingCompaniesList() { }

		public BindingCompaniesList(IList<BindingCompany> list) : base(list) { }
	}
}
