using System;
using System.Windows.Forms;
using WindowsFormsCompaniesManager.DataGridViewmodels;
using WindowsFormsCompaniesManager.FileConstructors;
using WindowsFormsCompaniesManager.Forms;

namespace WindowsFormsCompaniesManager
{
	public partial class StartForm : Form
	{
		private DataManager DataManager;

		public StartForm()
		{
			InitializeComponent();

			DataManager = new DataManager(
				DataGridViewCompanies,
				DataGridViewEmployees
			);
		}

		private void ButtonCreateEmployee_Click(object sender, EventArgs e)
		{
			using (CreateEmployee createEmployee = new CreateEmployee(DataManager, DataManager.SelectCompanyId))
			{
				createEmployee.ShowDialog();
			}
		}

		private void ButtonCreateCompany_Click(object sender, EventArgs e)
		{
			using (CreateCompany createCompany = new CreateCompany(DataManager))
			{
				createCompany.ShowDialog();
			}
		}

		private void RadioButtonOrder_CheckedChanged(object sender, EventArgs e)
		{
			var radioButton = (RadioButton)sender;
			if (radioButton == RadioButtonOrderName)
			{
				DataManager.SetEmployeeOrderProperty(EmployeeOrderProperty.Name);
			}
			else if (radioButton == RadioButtonOrderPosition)
			{
				DataManager.SetEmployeeOrderProperty(EmployeeOrderProperty.Position);
			}
			else if (radioButton == RadioButtonOrderDepartment)
			{
				DataManager.SetEmployeeOrderProperty(EmployeeOrderProperty.Department);
			}
		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			DataManager.SearchMode searchMode = default;
			if (RadioButtonSearchCompany.Checked)
				searchMode = DataManager.SearchMode.Company;
			else if (RadioButtonSearchEmployee.Checked)
				searchMode = DataManager.SearchMode.Employee;

			DataManager.SetSearchStringAndSearchMode(TextBoxSearchName.Text, searchMode);
		}

		private void ButtonSearchReset_Click(object sender, EventArgs e)
		{
			TextBoxSearchName.Text = "";
			RadioButtonSearchCompany.Checked = true;
			DataManager.SetSearchStringAndSearchMode(TextBoxSearchName.Text, DataManager.SearchMode.Employee);
			DataManager.SetSearchStringAndSearchMode(TextBoxSearchName.Text, DataManager.SearchMode.Company);
		}

		private void DownloadMSWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var doc = new DocxConstructor(DataManager).Construct();
			doc.Save();
		}

		private void DownloadJsonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new JsonConstructor(DataManager).Construct();
		}
	}
}