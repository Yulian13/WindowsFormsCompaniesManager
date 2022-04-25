using System;
using System.Windows.Forms;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.Forms
{
	public partial class CreateCompany : Form
	{
		private Company NewCompany => new Company() { Name = TextBoxName.Text };
		private DataManager DataManager;

		public CreateCompany(DataManager dataManager)
		{
			InitializeComponent();

			DataManager = dataManager;
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void ButtonCreate_Click(object sender, EventArgs e)
		{
			string validMessage = ValidateForm();

			if (String.IsNullOrEmpty(validMessage))
			{
				DataManager.AddCompany(NewCompany);
				DialogResult = DialogResult.OK;
			}
			else
			{
				SetLabelValidMessage(validMessage);
			}
		}

		private string ValidateForm()
		{
			string message = String.Empty;

			if (String.IsNullOrWhiteSpace(TextBoxName.Text))
			{
				message = "Enter value";
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
