using System;
using System.Collections.Generic;

namespace WindowsFormsCompaniesManager.EntityFramework.Models
{
	class Company
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		public List<Employee> Employees { get; set; } = new();
		public List<Department> Department { get; set; } = new();
	}
}
