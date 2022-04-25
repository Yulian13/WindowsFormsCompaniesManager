
namespace WindowsFormsCompaniesManager.Forms
{
	partial class CreateCompany
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonCreate = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.LabelValidateMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TextBoxName
			// 
			this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxName.Location = new System.Drawing.Point(12, 27);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(260, 23);
			this.TextBoxName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// ButtonCreate
			// 
			this.ButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonCreate.Location = new System.Drawing.Point(13, 86);
			this.ButtonCreate.Name = "ButtonCreate";
			this.ButtonCreate.Size = new System.Drawing.Size(87, 23);
			this.ButtonCreate.TabIndex = 2;
			this.ButtonCreate.Text = "Create";
			this.ButtonCreate.UseVisualStyleBackColor = true;
			this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonCancel.Location = new System.Drawing.Point(106, 86);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(87, 23);
			this.ButtonCancel.TabIndex = 3;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// LabelValidateMessage
			// 
			this.LabelValidateMessage.AutoSize = true;
			this.LabelValidateMessage.ForeColor = System.Drawing.Color.Red;
			this.LabelValidateMessage.Location = new System.Drawing.Point(12, 53);
			this.LabelValidateMessage.Name = "LabelValidateMessage";
			this.LabelValidateMessage.Size = new System.Drawing.Size(122, 15);
			this.LabelValidateMessage.TabIndex = 4;
			this.LabelValidateMessage.Text = "LabelValidateMessage";
			this.LabelValidateMessage.Visible = false;
			// 
			// CreateCompany
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 121);
			this.ControlBox = false;
			this.Controls.Add(this.LabelValidateMessage);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonCreate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextBoxName);
			this.MaximumSize = new System.Drawing.Size(500, 160);
			this.MinimumSize = new System.Drawing.Size(220, 160);
			this.Name = "CreateCompany";
			this.ShowIcon = false;
			this.Text = "Create company";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonCreate;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Label LabelValidateMessage;
	}
}