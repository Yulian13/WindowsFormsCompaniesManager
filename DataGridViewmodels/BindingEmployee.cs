using System;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.DataGridViewmodels
{
	public enum EmployeeOrderProperty
	{
		Name,
		Position,
		Department
	}
	class BindingEmployee
	{
		public BindingEmployee(Employee employee)
		{
			Id = employee.Id;
			Name = employee.Name;
			Address = employee.Address;
			Phone = employee.Phone;
			Position = employee.Position.Name;
			Department = employee.Department.Name;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Position { get; set; }
		public string Department { get; set; }
	}
}
