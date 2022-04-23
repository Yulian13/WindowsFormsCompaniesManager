
namespace WindowsFormsCompaniesManager
{
	partial class StartForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridCompanies = new System.Windows.Forms.DataGridView();
			this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCompanies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridCompanies
			// 
			this.dataGridCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCompanies.Location = new System.Drawing.Point(13, 193);
			this.dataGridCompanies.Name = "dataGridCompanies";
			this.dataGridCompanies.RowTemplate.Height = 25;
			this.dataGridCompanies.Size = new System.Drawing.Size(345, 232);
			this.dataGridCompanies.TabIndex = 0;
			// 
			// dataGridViewEmployees
			// 
			this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmployees.Location = new System.Drawing.Point(364, 193);
			this.dataGridViewEmployees.Name = "dataGridViewEmployees";
			this.dataGridViewEmployees.RowTemplate.Height = 25;
			this.dataGridViewEmployees.Size = new System.Drawing.Size(429, 232);
			this.dataGridViewEmployees.TabIndex = 1;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 437);
			this.Controls.Add(this.dataGridViewEmployees);
			this.Controls.Add(this.dataGridCompanies);
			this.Name = "StartForm";
			this.ShowIcon = false;
			this.Text = "Companies manager";
			((System.ComponentModel.ISupportInitialize)(this.dataGridCompanies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridCompanies;
		private System.Windows.Forms.DataGridView dataGridViewEmployees;
	}
}

