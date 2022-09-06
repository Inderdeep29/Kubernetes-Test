using Common.Repositories;
using Common.Models;
using Content.Helpers;

namespace Content.Repositories
{
	public class CountryListRepository : GenericRepository<CountryList>
	{
		public CountryListRepository(DataContext context) : base(context)
		{
		}

		public IEnumerable<CountryList> Test()
		{
			return null;// Get(i => i.Id == 1);
		}
	}
}
