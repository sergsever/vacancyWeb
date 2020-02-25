using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacancyWeb.Data
{
	public class VacansiesDAO :IDAO<Vacancies, int>
	{
		private VacancyContext dbcontext { get; set; }

		public VacansiesDAO(VacancyContext context)
		{
			dbcontext = context;
		}

		public IEnumerable<Vacancies> getAll()
		{
			List<Vacancies> res = dbcontext.vacancies.Where(e => e.Id != null && e.Date != null).ToList();
			return res;
		}

		public Vacancies Find(int key)
		{
			Vacancies res = dbcontext.vacancies.Find(key);
			return res;
		}

		public void Add(Vacancies entity)
		{
			dbcontext.vacancies.Add(entity);
			dbcontext.SaveChanges();
		}
	}
}
