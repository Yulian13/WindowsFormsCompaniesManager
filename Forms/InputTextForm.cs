using System;
using System.Windows.Forms;

namespace WindowsFormsCompaniesManager.Forms
{
	public partial class InputTextForm : Form
	{
		public string InputValue => TextBoxName.Text;

		public InputTextForm(string title)
		{
			InitializeComponent();

			this.Text = title;
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
