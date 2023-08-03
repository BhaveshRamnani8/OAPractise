using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class CountryRepo : ICountryRepo
    {
        private DbSet<Country> entities;

        public CountryRepo(OAContext context)
        {
            entities = context.Set<Country>();
        }

        public IEnumerable<Country> GetCountries()
        {
            return entities.AsEnumerable();
        }
    }
}
