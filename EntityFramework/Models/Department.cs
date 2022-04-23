using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCompaniesManager.EntityFramework.Models
{
	class Department
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public List<Employee> Employees { get; set; } = new();

		public Guid CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
