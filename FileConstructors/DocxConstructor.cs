using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsCompaniesManager.EntityFramework.Models;
using Xceed.Words.NET;

namespace WindowsFormsCompaniesManager.FileConstructors
{
	class DocxConstructor
	{
		private readonly string _FileName = $"{Directory.GetCurrentDirectory()}/Downloads/Docx";
		private DataManager DataManager;
		private List<Company> Companies;

		public DocxConstructor(DataManager dataManager)
		{
			DataManager = dataManager;
			Companies = DataManager.GetCompanies().ToList();

			Directory.CreateDirectory(_FileName);
			_FileName += $"/{DateTime.Now.ToString("yyyy/MM/dd")}.docx";
		}

		public DocX Construct()
		{
			DocX doc = DocX.Create(_FileName);

			doc.InsertParagraph(
				GetText()
			);

			return doc;
		}

		private string GetText()
		{
			string text = String.Empty;

			foreach (Company company in Companies)
			{
				text += $"{company.Name}\r";
				List<Employee> employees = DataManager.GetEmployeesByCompanyId(company.Id).ToList();
				var deportaments = employees.GroupBy(emp => emp.Department);

				foreach (var department in deportaments)
				{
					text += $"\t{department.Key.Name}\r";
					foreach (Employee employee in department)
					{
						text += $"\t\t{employee.Name} \t {employee.Address} \t {employee.Phone} \t {employee.Position.Name}\r";
					}
				}
			}

			return text;
		}
	}
}
