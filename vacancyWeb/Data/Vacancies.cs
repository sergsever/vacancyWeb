using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacancyWeb.Data
{
	public class Vacancies
	{
		public Vacancies()
		{
			Date = DateTime.Now;
		}
		public int? Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }

	}
}
