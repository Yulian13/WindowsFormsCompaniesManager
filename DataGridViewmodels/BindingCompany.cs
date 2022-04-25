using System;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.DataGridViewmodels
{
	class BindingCompany
	{
		public BindingCompany(Company company)
		{
			Id = company.Id;
			Name = company.Name;
			EmployeesNumber = company.Employees.Count;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public int EmployeesNumber { get; set; }
	}
}
