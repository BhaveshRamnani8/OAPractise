using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class CityService : ICityService
    {
        private ICityRepo _repo;
        public CityService(ICityRepo cityRepo)
        {
            _repo = cityRepo;
        }
        public IEnumerable<City> GetCities(long stateId)
        {
            return _repo.GetCities(stateId);
        }
    }
}
