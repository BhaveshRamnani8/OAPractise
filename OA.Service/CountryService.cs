using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class CountryService : ICountryService
    {
        private ICountryRepo _repo;
        public CountryService(ICountryRepo countryRepo)
        {
            _repo= countryRepo;
        }

        public IEnumerable<Country> GetCountries()
        {
            return _repo.GetCountries();
        }
    }
}
