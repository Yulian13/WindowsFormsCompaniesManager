
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.DataGridViewCompanies = new System.Windows.Forms.DataGridView();
			this.DataGridViewEmployees = new System.Windows.Forms.DataGridView();
			this.ButtonCreateCompany = new System.Windows.Forms.Button();
			this.ButtonCreateEmployee = new System.Windows.Forms.Button();
			this.RadioButtonOrderName = new System.Windows.Forms.RadioButton();
			this.GroupBoxRadioEmployeeOrder = new System.Windows.Forms.GroupBox();
			this.RadioButtonOrderDepartment = new System.Windows.Forms.RadioButton();
			this.RadioButtonOrderPosition = new System.Windows.Forms.RadioButton();
			this.TextBoxSearchName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButtonSearchCompany = new System.Windows.Forms.RadioButton();
			this.RadioButtonSearchEmployee = new System.Windows.Forms.RadioButton();
			this.ButtonSearch = new System.Windows.Forms.Button();
			this.ButtonSearchReset = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButtonDownload = new System.Windows.Forms.ToolStripDropDownButton();
			this.DownloadMSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DownloadJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompanies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployees)).BeginInit();
			this.GroupBoxRadioEmployeeOrder.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGridViewCompanies
			// 
			this.DataGridViewCompanies.AllowUserToAddRows = false;
			this.DataGridViewCompanies.AllowUserToDeleteRows = false;
			this.DataGridViewCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.DataGridViewCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewCompanies.Location = new System.Drawing.Point(13, 137);
			this.DataGridViewCompanies.MultiSelect = false;
			this.DataGridViewCompanies.Name = "DataGridViewCompanies";
			this.DataGridViewCompanies.ReadOnly = true;
			this.DataGridViewCompanies.RowTemplate.Height = 25;
			this.DataGridViewCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DataGridViewCompanies.Size = new System.Drawing.Size(345, 212);
			this.DataGridViewCompanies.TabIndex = 1;
			// 
			// DataGridViewEmployees
			// 
			this.DataGridViewEmployees.AllowUserToAddRows = false;
			this.DataGridViewEmployees.AllowUserToDeleteRows = false;
			this.DataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewEmployees.Location = new System.Drawing.Point(364, 137);
			this.DataGridViewEmployees.MultiSelect = false;
			this.DataGridViewEmployees.Name = "DataGridViewEmployees";
			this.DataGridViewEmployees.ReadOnly = true;
			this.DataGridViewEmployees.RowTemplate.Height = 25;
			this.DataGridViewEmployees.Size = new System.Drawing.Size(348, 212);
			this.DataGridViewEmployees.TabIndex = 1;
			// 
			// ButtonCreateCompany
			// 
			this.ButtonCreateCompany.Location = new System.Drawing.Point(13, 107);
			this.ButtonCreateCompany.Name = "ButtonCreateCompany";
			this.ButtonCreateCompany.Size = new System.Drawing.Size(104, 24);
			this.ButtonCreateCompany.TabIndex = 1;
			this.ButtonCreateCompany.Text = "Create company\r\n";
			this.ButtonCreateCompany.UseVisualStyleBackColor = true;
			this.ButtonCreateCompany.Click += new System.EventHandler(this.ButtonCreateCompany_Click);
			// 
			// ButtonCreateEmployee
			// 
			this.ButtonCreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCreateEmployee.Location = new System.Drawing.Point(608, 107);
			this.ButtonCreateEmployee.Name = "ButtonCreateEmployee";
			this.ButtonCreateEmployee.Size = new System.Drawing.Size(104, 24);
			this.ButtonCreateEmployee.TabIndex = 2;
			this.ButtonCreateEmployee.Text = "Create employee";
			this.ButtonCreateEmployee.UseVisualStyleBackColor = true;
			this.ButtonCreateEmployee.Click += new System.EventHandler(this.ButtonCreateEmployee_Click);
			// 
			// RadioButtonOrderName
			// 
			this.RadioButtonOrderName.AutoSize = true;
			this.RadioButtonOrderName.Checked = true;
			this.RadioButtonOrderName.Location = new System.Drawing.Point(6, 13);
			this.RadioButtonOrderName.Name = "RadioButtonOrderName";
			this.RadioButtonOrderName.Size = new System.Drawing.Size(57, 19);
			this.RadioButtonOrderName.TabIndex = 3;
			this.RadioButtonOrderName.TabStop = true;
			this.RadioButtonOrderName.Text = "Name";
			this.RadioButtonOrderName.UseVisualStyleBackColor = true;
			this.RadioButtonOrderName.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
			// 
			// GroupBoxRadioEmployeeOrder
			// 
			this.GroupBoxRadioEmployeeOrder.Controls.Add(this.RadioButtonOrderDepartment);
			this.GroupBoxRadioEmployeeOrder.Controls.Add(this.RadioButtonOrderPosition);
			this.GroupBoxRadioEmployeeOrder.Controls.Add(this.RadioButtonOrderName);
			this.GroupBoxRadioEmployeeOrder.Location = new System.Drawing.Point(366, 92);
			this.GroupBoxRadioEmployeeOrder.Name = "GroupBoxRadioEmployeeOrder";
			this.GroupBoxRadioEmployeeOrder.Size = new System.Drawing.Size(236, 39);
			this.GroupBoxRadioEmployeeOrder.TabIndex = 4;
			this.GroupBoxRadioEmployeeOrder.TabStop = false;
			// 
			// RadioButtonOrderDepartment
			// 
			this.RadioButtonOrderDepartment.AutoSize = true;
			this.RadioButtonOrderDepartment.Location = new System.Drawing.Point(143, 13);
			this.RadioButtonOrderDepartment.Name = "RadioButtonOrderDepartment";
			this.RadioButtonOrderDepartment.Size = new System.Drawing.Size(88, 19);
			this.RadioButtonOrderDepartment.TabIndex = 5;
			this.RadioButtonOrderDepartment.Text = "Department";
			this.RadioButtonOrderDepartment.UseVisualStyleBackColor = true;
			this.RadioButtonOrderDepartment.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
			// 
			// RadioButtonOrderPosition
			// 
			this.RadioButtonOrderPosition.AutoSize = true;
			this.RadioButtonOrderPosition.Location = new System.Drawing.Point(69, 13);
			this.RadioButtonOrderPosition.Name = "RadioButtonOrderPosition";
			this.RadioButtonOrderPosition.Size = new System.Drawing.Size(68, 19);
			this.RadioButtonOrderPosition.TabIndex = 4;
			this.RadioButtonOrderPosition.Text = "Position";
			this.RadioButtonOrderPosition.UseVisualStyleBackColor = true;
			this.RadioButtonOrderPosition.CheckedChanged += new System.EventHandler(this.RadioButtonOrder_CheckedChanged);
			// 
			// TextBoxSearchName
			// 
			this.TextBoxSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxSearchName.Location = new System.Drawing.Point(13, 33);
			this.TextBoxSearchName.Name = "TextBoxSearchName";
			this.TextBoxSearchName.Size = new System.Drawing.Size(699, 23);
			this.TextBoxSearchName.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RadioButtonSearchCompany);
			this.groupBox1.Controls.Add(this.RadioButtonSearchEmployee);
			this.groupBox1.Location = new System.Drawing.Point(13, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 39);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// RadioButtonSearchCompany
			// 
			this.RadioButtonSearchCompany.AutoSize = true;
			this.RadioButtonSearchCompany.Checked = true;
			this.RadioButtonSearchCompany.Location = new System.Drawing.Point(6, 13);
			this.RadioButtonSearchCompany.Name = "RadioButtonSearchCompany";
			this.RadioButtonSearchCompany.Size = new System.Drawing.Size(77, 19);
			this.RadioButtonSearchCompany.TabIndex = 4;
			this.RadioButtonSearchCompany.TabStop = true;
			this.RadioButtonSearchCompany.Text = "Company";
			this.RadioButtonSearchCompany.UseVisualStyleBackColor = true;
			// 
			// RadioButtonSearchEmployee
			// 
			this.RadioButtonSearchEmployee.AutoSize = true;
			this.RadioButtonSearchEmployee.Location = new System.Drawing.Point(88, 13);
			this.RadioButtonSearchEmployee.Name = "RadioButtonSearchEmployee";
			this.RadioButtonSearchEmployee.Size = new System.Drawing.Size(77, 19);
			this.RadioButtonSearchEmployee.TabIndex = 3;
			this.RadioButtonSearchEmployee.Text = "Employee";
			this.RadioButtonSearchEmployee.UseVisualStyleBackColor = true;
			// 
			// ButtonSearch
			// 
			this.ButtonSearch.Location = new System.Drawing.Point(187, 68);
			this.ButtonSearch.Name = "ButtonSearch";
			this.ButtonSearch.Size = new System.Drawing.Size(86, 26);
			this.ButtonSearch.TabIndex = 7;
			this.ButtonSearch.Text = "Search";
			this.ButtonSearch.UseVisualStyleBackColor = true;
			this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
			// 
			// ButtonSearchReset
			// 
			this.ButtonSearchReset.Location = new System.Drawing.Point(279, 68);
			this.ButtonSearchReset.Name = "ButtonSearchReset";
			this.ButtonSearchReset.Size = new System.Drawing.Size(86, 26);
			this.ButtonSearchReset.TabIndex = 8;
			this.ButtonSearchReset.Text = "Reset";
			this.ButtonSearchReset.UseVisualStyleBackColor = true;
			this.ButtonSearchReset.Click += new System.EventHandler(this.ButtonSearchReset_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonDownload});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(724, 25);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButtonDownload
			// 
			this.toolStripDropDownButtonDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonDownload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadMSWordToolStripMenuItem,
            this.DownloadJsonToolStripMenuItem});
			this.toolStripDropDownButtonDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDownload.Image")));
			this.toolStripDropDownButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonDownload.Name = "toolStripDropDownButtonDownload";
			this.toolStripDropDownButtonDownload.Size = new System.Drawing.Size(74, 22);
			this.toolStripDropDownButtonDownload.Text = "Download";
			// 
			// DownloadMSWordToolStripMenuItem
			// 
			this.DownloadMSWordToolStripMenuItem.Name = "DownloadMSWordToolStripMenuItem";
			this.DownloadMSWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.DownloadMSWordToolStripMenuItem.Text = "MS  word";
			this.DownloadMSWordToolStripMenuItem.Click += new System.EventHandler(this.DownloadMSWordToolStripMenuItem_Click);
			// 
			// DownloadJsonToolStripMenuItem
			// 
			this.DownloadJsonToolStripMenuItem.Name = "DownloadJsonToolStripMenuItem";
			this.DownloadJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.DownloadJsonToolStripMenuItem.Text = "Json";
			this.DownloadJsonToolStripMenuItem.Click += new System.EventHandler(this.DownloadJsonToolStripMenuItem_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 361);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.ButtonSearchReset);
			this.Controls.Add(this.ButtonSearch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TextBoxSearchName);
			this.Controls.Add(this.GroupBoxRadioEmployeeOrder);
			this.Controls.Add(this.ButtonCreateEmployee);
			this.Controls.Add(this.ButtonCreateCompany);
			this.Controls.Add(this.DataGridViewEmployees);
			this.Controls.Add(this.DataGridViewCompanies);
			this.MaximumSize = new System.Drawing.Size(1500, 4000);
			this.MinimumSize = new System.Drawing.Size(740, 400);
			this.Name = "StartForm";
			this.ShowIcon = false;
			this.Text = "Companies manager";
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompanies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployees)).EndInit();
			this.GroupBoxRadioEmployeeOrder.ResumeLayout(false);
			this.GroupBoxRadioEmployeeOrder.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DataGridViewCompanies;
		private System.Windows.Forms.DataGridView DataGridViewEmployees;
		private System.Windows.Forms.Button ButtonCreateCompany;
		private System.Windows.Forms.Button ButtonCreateEmployee;
		private System.Windows.Forms.RadioButton RadioButtonOrderName;
		private System.Windows.Forms.GroupBox GroupBoxRadioEmployeeOrder;
		private System.Windows.Forms.RadioButton RadioButtonOrderPosition;
		private System.Windows.Forms.RadioButton RadioButtonOrderDepartment;
		private System.Windows.Forms.TextBox TextBoxSearchName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton RadioButtonSearchCompany;
		private System.Windows.Forms.RadioButton RadioButtonSearchEmployee;
		private System.Windows.Forms.Button ButtonSearch;
		private System.Windows.Forms.Button ButtonSearchReset;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDownload;
		private System.Windows.Forms.ToolStripMenuItem DownloadMSWordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DownloadJsonToolStripMenuItem;
	}
}

