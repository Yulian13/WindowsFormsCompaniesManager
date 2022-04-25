using System;
using System.Collections.Generic;

namespace WindowsFormsCompaniesManager.EntityFramework.Models
{
	public class Department
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public List<Employee> Employees { get; set; } = new();

		public Guid CompanyId { get; set; }
		public Company Company { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
