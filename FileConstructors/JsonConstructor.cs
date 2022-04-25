using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.FileConstructors
{
	class JsonConstructor
	{
		private readonly string _FileName = $"{Directory.GetCurrentDirectory()}/Downloads/Json";

		private List<Company> Companies;
		private List<Employee> Employees;

		public JsonConstructor(DataManager dataManager)
		{
			Companies = dataManager.GetCompanies().ToList();
			Employees = dataManager.GetAllEmployees().ToList();

			Directory.CreateDirectory(_FileName);
			_FileName += $"/{DateTime.Now.ToString("yyyy/MM/dd")}.json";
		}

		public void Construct()
		{
			dynamic jsonCompanies = Companies.Select(
				comp => new
				{
					Id = comp.Id,
					Name = comp.Name
				}
			);
			dynamic jsonEmployees = Employees.Select(
				employee => new
				{
					Id = employee.Id,
					Name = employee.Name,
					Address = employee.Address,
					Phone = employee.Phone,
					Position = employee.Position.Name,
					Department = employee.Department.Name,
					CompanyId = employee.CompanyId,
				}
			);

			string json = JsonConvert.SerializeObject(new
			{
				Companies = jsonCompanies,
				Employees = jsonEmployees,
			}, Formatting.Indented);

			File.WriteAllText(_FileName, json);
		}
	}
}
