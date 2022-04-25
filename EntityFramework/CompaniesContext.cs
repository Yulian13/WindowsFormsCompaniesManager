using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using WindowsFormsCompaniesManager.EntityFramework.Models;

namespace WindowsFormsCompaniesManager.EntityFramework
{
	class CompaniesContext : DbContext
	{
		public DbSet<Company> Companies { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Department> Departments { get; set; }

		public CompaniesContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connection = GetConnectionString();
			optionsBuilder.UseSqlServer(connection);
		}

		private string GetConnectionString()
			=> new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build()
				.GetConnectionString("CompaniesBD");
	}
}
