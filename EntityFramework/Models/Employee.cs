using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCompaniesManager.EntityFramework.Models
{
	class Employee
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public Position Position { get; set; }
		public Department Department { get; set; }


		public Guid CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
