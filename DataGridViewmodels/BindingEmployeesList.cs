using System;
using System.Collections.Generic;

namespace WindowsFormsCompaniesManager.DataGridViewmodels
{
	class BindingEmployeesList : CustomBindingList<BindingEmployee>
	{
		public BindingEmployeesList() { }

		public BindingEmployeesList(IList<BindingEmployee> list) : base(list) { }

		public void OrderByStringProperty(EmployeeOrderProperty propertyName)
		{
			OrderBy(
				emp => emp.GetType()
					.GetProperty(Enum.GetName(typeof(EmployeeOrderProperty), propertyName))
					.GetValue(emp)
					.ToString()
			);
		}
	}
}
