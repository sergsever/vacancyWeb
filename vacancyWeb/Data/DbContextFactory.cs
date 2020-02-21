using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacancyWeb.Data
{
	public class DbContextFactory : IDesignTimeDbContextFactory<VacancyContext>
	{
		public VacancyContext CreateDbContext(string[] args)
		{
			var builder = new ConfigurationBuilder()
							.AddJsonFile("appsettings.json");
			var conf = builder.Build();
			String connection = conf.GetConnectionString("MSSQL");
			DbContextOptionsBuilder<VacancyContext> ob = new DbContextOptionsBuilder<VacancyContext>();
			ob.UseSqlServer(connection);
			var options = ob.Options;
			return new VacancyContext(options);


							
		}
	}
}
