
namespace WindowsFormsCompaniesManager.Forms
{
	partial class CreateEmployee
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
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.TextBoxAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ComboBoxPosition = new System.Windows.Forms.ComboBox();
			this.ButtonCreatePosition = new System.Windows.Forms.Button();
			this.ButtonCreateDepartment = new System.Windows.Forms.Button();
			this.ComboBoxDepartment = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ButtonCreate = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.LabelValidateMessage = new System.Windows.Forms.Label();
			this.TextBoxPhone = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// TextBoxName
			// 
			this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxName.Location = new System.Drawing.Point(13, 32);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(319, 23);
			this.TextBoxName.TabIndex = 1;
			// 
			// TextBoxAddress
			// 
			this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxAddress.Location = new System.Drawing.Point(13, 77);
			this.TextBoxAddress.Name = "TextBoxAddress";
			this.TextBoxAddress.Size = new System.Drawing.Size(319, 23);
			this.TextBoxAddress.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Position";
			// 
			// ComboBoxPosition
			// 
			this.ComboBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBoxPosition.FormattingEnabled = true;
			this.ComboBoxPosition.Location = new System.Drawing.Point(13, 167);
			this.ComboBoxPosition.Name = "ComboBoxPosition";
			this.ComboBoxPosition.Size = new System.Drawing.Size(236, 23);
			this.ComboBoxPosition.TabIndex = 7;
			// 
			// ButtonCreatePosition
			// 
			this.ButtonCreatePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCreatePosition.Location = new System.Drawing.Point(255, 167);
			this.ButtonCreatePosition.Name = "ButtonCreatePosition";
			this.ButtonCreatePosition.Size = new System.Drawing.Size(77, 23);
			this.ButtonCreatePosition.TabIndex = 8;
			this.ButtonCreatePosition.Text = "Add";
			this.ButtonCreatePosition.UseVisualStyleBackColor = true;
			this.ButtonCreatePosition.Click += new System.EventHandler(this.ButtonCreatePosition_Click);
			// 
			// ButtonCreateDepartment
			// 
			this.ButtonCreateDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCreateDepartment.Location = new System.Drawing.Point(255, 211);
			this.ButtonCreateDepartment.Name = "ButtonCreateDepartment";
			this.ButtonCreateDepartment.Size = new System.Drawing.Size(77, 23);
			this.ButtonCreateDepartment.TabIndex = 11;
			this.ButtonCreateDepartment.Text = "Add";
			this.ButtonCreateDepartment.UseVisualStyleBackColor = true;
			this.ButtonCreateDepartment.Click += new System.EventHandler(this.ButtonCreateDepartment_Click);
			// 
			// ComboBoxDepartment
			// 
			this.ComboBoxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBoxDepartment.FormattingEnabled = true;
			this.ComboBoxDepartment.Location = new System.Drawing.Point(14, 211);
			this.ComboBoxDepartment.Name = "ComboBoxDepartment";
			this.ComboBoxDepartment.Size = new System.Drawing.Size(235, 23);
			this.ComboBoxDepartment.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Department";
			// 
			// ButtonCreate
			// 
			this.ButtonCreate.Location = new System.Drawing.Point(12, 296);
			this.ButtonCreate.Name = "ButtonCreate";
			this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
			this.ButtonCreate.TabIndex = 12;
			this.ButtonCreate.Text = "Create";
			this.ButtonCreate.UseVisualStyleBackColor = true;
			this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(93, 296);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 13;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// LabelValidateMessage
			// 
			this.LabelValidateMessage.AutoSize = true;
			this.LabelValidateMessage.ForeColor = System.Drawing.Color.Red;
			this.LabelValidateMessage.Location = new System.Drawing.Point(12, 256);
			this.LabelValidateMessage.Name = "LabelValidateMessage";
			this.LabelValidateMessage.Size = new System.Drawing.Size(122, 15);
			this.LabelValidateMessage.TabIndex = 15;
			this.LabelValidateMessage.Text = "LabelValidateMessage";
			this.LabelValidateMessage.Visible = false;
			// 
			// TextBoxPhone
			// 
			this.TextBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxPhone.Location = new System.Drawing.Point(14, 121);
			this.TextBoxPhone.Name = "TextBoxPhone";
			this.TextBoxPhone.Size = new System.Drawing.Size(318, 23);
			this.TextBoxPhone.TabIndex = 16;
			// 
			// CreateEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 331);
			this.ControlBox = false;
			this.Controls.Add(this.TextBoxPhone);
			this.Controls.Add(this.LabelValidateMessage);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonCreate);
			this.Controls.Add(this.ButtonCreateDepartment);
			this.Controls.Add(this.ComboBoxDepartment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ButtonCreatePosition);
			this.Controls.Add(this.ComboBoxPosition);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TextBoxAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(1000, 370);
			this.MinimumSize = new System.Drawing.Size(360, 370);
			this.Name = "CreateEmployee";
			this.ShowIcon = false;
			this.Text = "Create employee";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.TextBox TextBoxAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox ComboBoxPosition;
		private System.Windows.Forms.Button ButtonCreatePosition;
		private System.Windows.Forms.Button ButtonCreateDepartment;
		private System.Windows.Forms.ComboBox ComboBoxDepartment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ButtonCreate;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Label LabelValidateMessage;
		private System.Windows.Forms.TextBox TextBoxPhone;
	}
}