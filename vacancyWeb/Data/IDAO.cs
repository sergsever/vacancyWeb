using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacancyWeb.Data
{
	public interface IDAO<TE, TKey>
	{
		IEnumerable<TE> getAll();
		TE Find(TKey key);
		void Add(TE entity);

	}
}
