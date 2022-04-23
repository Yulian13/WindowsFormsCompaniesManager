using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCompaniesManager.EntityFramework;

namespace WindowsFormsCompaniesManager
{
	public partial class StartForm : Form
	{
		private CompaniesContext context;

		public StartForm()
		{
			InitializeComponent();

			context = new CompaniesContext();
			context.Companies.Load();

			dataGridCompanies.DataSource = context.Companies.Local.ToBindingList();
		}

	}
}
