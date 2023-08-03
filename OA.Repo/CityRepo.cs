using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class CityRepo : ICityRepo
    {
        private DbSet<City> entities;

        public CityRepo(OAContext context)
        {     
            entities = context.Set<City>();
        }        

        public IEnumerable<City> GetCities(long stateId)
        {
            return entities.Where(c=>c.StateId == stateId);
        }
    }
}
