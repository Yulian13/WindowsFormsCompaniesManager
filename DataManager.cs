using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsCompaniesManager.DataGridViewmodels;
using WindowsFormsCompaniesManager.EntityFramework;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager
{
	public class DataManager
	{
		private CompaniesContext Context;
		private BindingCompaniesList BindingCompaniesList = new();
		private BindingEmployeesList BindingEmployeesList = new();

		private DataGridView DataGridViewCompanies;
		private DataGridView DataGridViewEmployees;
		private EmployeeOrderProperty OrderProperty = EmployeeOrderProperty.Name;
		private string SearchString = String.Empty;
		private SearchMode _SearchMode = SearchMode.Company;

		public Guid SelectCompanyId { get; private set; }

		public DataManager(DataGridView dataGridViewCompanies, DataGridView dataGridViewEmployees)
		{
			Context = new CompaniesContext();
			Context.Departments.Load();
			Context.Positions.Load();

			DataGridViewCompanies = dataGridViewCompanies;
			DataGridViewEmployees = dataGridViewEmployees;

			DataGridViewCompanies.SelectionChanged += new EventHandler(DataGridViewCompanies_SelectionChanged);

			InitBindengCompaniesList();

			BindDataGridViewCompanies();
			BindDataGridViewEmployees();
		}

		public void AddCompany(Company company)
		{
			Context.Companies.Add(company);
			Context.SaveChanges();

			BindingCompaniesList.Add(new BindingCompany(company));
		}

		public void AddEmployee(Employee employee)
		{
			Context.Employees.Add(employee);
			Context.SaveChanges();

			BindingEmployeesList.Add(
				new BindingEmployee(employee)
			);
			InitBindengCompaniesList();
		}

		public Department AddDepartment(string name, Guid companyId)
		{
			var department = new Department() { Name = name, CompanyId = companyId };
			Context.Departments.Add(department);
			Context.SaveChanges();

			return department;
		}

		public Position AddPosition(string name)
		{
			var position = new Position() { Name = name };
			Context.Positions.Add(position);
			Context.SaveChanges();

			return position;
		}

		public IEnumerable<Position> GetPositions()
			=> new List<Position>(Context.Positions);

		public IEnumerable<Department> GetDepartmentsByCompanyId(Guid companyId)
			=> new List<Department>(
					Context.Departments
					.Where(dep => dep.CompanyId == companyId)
				);

		public IEnumerable<Company> GetCompanies()
			=> new List<Company>(Context.Companies);
		public IEnumerable<Employee> GetAllEmployees()
			=> new List<Employee>(Context.Employees.Include(emp => emp.Company));
		public IEnumerable<Employee> GetEmployeesByCompanyId(Guid companyId)
			=> new List<Employee>(Context.Employees
				.Where(emp => emp.CompanyId == companyId)
			);

		public void SetEmployeeOrderProperty(EmployeeOrderProperty property)
		{
			OrderProperty = property;
			InitBindingEmployeesList();
		}

		public void SetSearchStringAndSearchMode(string searchString, SearchMode searchMode)
		{
			SearchString = searchString;
			_SearchMode = searchMode;
			switch (_SearchMode)
			{
				case SearchMode.Company:
					InitBindengCompaniesList();
					break;
				case SearchMode.Employee:
					InitBindingEmployeesList();
					break;
			}
		}

		private void InitBindengCompaniesList()
		{
			BindingCompaniesList.Clear();
			var bindingCompaniesList = new BindingCompaniesList(
				Context.Companies
				.Where(comp => (SearchString != String.Empty && _SearchMode == SearchMode.Company) ? comp.Name.Contains(SearchString) : true)
				.Include(comp => comp.Employees)
				.OrderBy(comp => comp.Name)
				.Select(
					comp => new BindingCompany(comp)
				).ToList()
			);
			BindingCompaniesList.AddRange(bindingCompaniesList);
		}

		private void InitBindingEmployeesList()
		{
			BindingEmployeesList.Clear();
			var bindingEmployeesList = Context.Employees
				.Where(emp => emp.CompanyId == SelectCompanyId)
				.Where(emp => (SearchString != String.Empty && _SearchMode == SearchMode.Employee) ? emp.Name.Contains(SearchString) : true)
				.Select(
					emp => new BindingEmployee(emp)
				).ToList();
			BindingEmployeesList.AddRange(bindingEmployeesList);
			BindingEmployeesList.OrderByStringProperty(OrderProperty);
		}

		private void BindDataGridViewCompanies()
		{
			DataGridViewCompanies.DataSource = BindingCompaniesList;

			DataGridViewCompanies.Columns["Id"].Visible = false;
		}

		private void BindDataGridViewEmployees()
		{
			DataGridViewEmployees.DataSource = BindingEmployeesList;

			DataGridViewEmployees.Columns["Id"].Visible = false;
		}

		private void DataGridViewCompanies_SelectionChanged(object sender, EventArgs e)
		{
			if (DataGridViewCompanies.SelectedCells.Count != 1)
			{
				return;
			}

			int selectRowIndex = DataGridViewCompanies.SelectedCells[0].RowIndex;
			Guid companyId = (Guid)DataGridViewCompanies["Id", selectRowIndex].Value;

			if (SelectCompanyId != companyId)
			{
				SelectCompanyId = companyId;
				InitBindingEmployeesList();
			}
		}

		public enum SearchMode
		{
			Company,
			Employee,
		}
	}
}
