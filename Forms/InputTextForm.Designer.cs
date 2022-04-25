
namespace WindowsFormsCompaniesManager.Forms
{
	partial class InputTextForm
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
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonCreate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.LabelValidateMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(105, 86);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(87, 23);
			this.ButtonCancel.TabIndex = 7;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// ButtonCreate
			// 
			this.ButtonCreate.Location = new System.Drawing.Point(12, 86);
			this.ButtonCreate.Name = "ButtonCreate";
			this.ButtonCreate.Size = new System.Drawing.Size(87, 23);
			this.ButtonCreate.TabIndex = 6;
			this.ButtonCreate.Text = "Create";
			this.ButtonCreate.UseVisualStyleBackColor = true;
			this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Name";
			// 
			// TextBoxName
			// 
			this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxName.Location = new System.Drawing.Point(12, 27);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(260, 23);
			this.TextBoxName.TabIndex = 4;
			// 
			// LabelValidateMessage
			// 
			this.LabelValidateMessage.AutoSize = true;
			this.LabelValidateMessage.ForeColor = System.Drawing.Color.Red;
			this.LabelValidateMessage.Location = new System.Drawing.Point(12, 53);
			this.LabelValidateMessage.Name = "LabelValidateMessage";
			this.LabelValidateMessage.Size = new System.Drawing.Size(122, 15);
			this.LabelValidateMessage.TabIndex = 8;
			this.LabelValidateMessage.Text = "LabelValidateMessage";
			this.LabelValidateMessage.Visible = false;
			// 
			// InputTextForm
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
			this.Name = "InputTextForm";
			this.ShowIcon = false;
			this.Text = "InputTextForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonCreate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.Label LabelValidateMessage;
	}
}