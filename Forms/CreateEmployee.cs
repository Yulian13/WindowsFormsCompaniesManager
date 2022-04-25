using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.Forms
{
	public partial class CreateEmployee : Form
	{
		private Guid CompanyId;
		private DataManager DataManager;

		public CreateEmployee(DataManager dataManager, Guid companyId)
		{
			InitializeComponent();

			DataManager = dataManager;
			CompanyId = companyId;

			ComboBoxDepartment.Items.AddRange(
				DataManager.GetDepartmentsByCompanyId(CompanyId).ToArray()
			);
			ComboBoxPosition.Items.AddRange(
				DataManager.GetPositions().ToArray()
			);
		}

		private Employee GetNewEmployee()
			=> new Employee()
			{
				Name = TextBoxName.Text,
				Address = TextBoxAddress.Text,
				Phone = TextBoxPhone.Text,
				Department = (Department)ComboBoxDepartment.SelectedItem,
				Position = (Position)ComboBoxPosition.SelectedItem,
				CompanyId = CompanyId,
			};

		private void ButtonCreateDepartment_Click(object sender, EventArgs e)
		{
			string inputText = GetValueFromInputTextFrom("Add department");
			if (inputText != null)
			{
				Department department = DataManager.AddDepartment(inputText, CompanyId);
				ComboBoxDepartment.Items.Add(department);
			}
		}

		private void ButtonCreatePosition_Click(object sender, EventArgs e)
		{
			string inputText = GetValueFromInputTextFrom("Add position");
			if (inputText != null)
			{
				Position position = DataManager.AddPosition(inputText);
				ComboBoxPosition.Items.Add(position);
			}
		}

		private string GetValueFromInputTextFrom(string title)
		{
			using (InputTextForm inputTextForm = new InputTextForm(title))
			{
				inputTextForm.ShowDialog();
				return (inputTextForm.DialogResult == DialogResult.OK) ? inputTextForm.InputValue : null;
			}
		}

		private void ButtonCreate_Click(object sender, EventArgs e)
		{
			string validMessage = ValidateForm();

			if (String.IsNullOrEmpty(validMessage))
			{
				DataManager.AddEmployee(
					GetNewEmployee()
				);
				DialogResult = DialogResult.OK;
			}
			else
			{
				SetLabelValidMessage(validMessage);
			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private string ValidateForm()
		{
			string message = String.Empty;

			if (String.IsNullOrWhiteSpace(TextBoxName.Text))
			{
				message = "Enter Name";
			}

			if (ComboBoxDepartment.SelectedItem == null)
			{
				message = "Select department";
			}

			if (ComboBoxPosition.SelectedItem == null)
			{
				message = "Select position";
			}

			return message;
		}

		private void SetLabelValidMessage(string text)
		{
			LabelValidateMessage.Visible = true;
			LabelValidateMessage.Text = text;
		}
	}
}
