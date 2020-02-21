using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacancyWeb.Data
{
	public class VacancyContext : DbContext
	{
		public VacancyContext(DbContextOptions<VacancyContext> options) : base(options) { }
		public DbSet<Vacancies> vacancies { get; set; }
	}
}
