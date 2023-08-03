using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class StateRepo : IStateRepo
    {
        private DbSet<State> entities;

        public StateRepo(OAContext context)
        {
            entities = context.Set<State>();
        }

        public IEnumerable<State> GetStates(long countryId)
        {
            return entities.Where(s=> s.CountryId == countryId);
        }
    }
}
