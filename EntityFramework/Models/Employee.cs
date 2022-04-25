using System;

namespace WindowsFormsCompaniesManager.EntityFramework.Models
{
	public class Employee
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

		public Guid PositionId { get; set; }
		public Position Position { get; set; }

		public Guid DepartmentId { get; set; }
		public Department Department { get; set; }


		public Guid CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
