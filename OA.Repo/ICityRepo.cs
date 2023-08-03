using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface ICityRepo
    {
        IEnumerable<City> GetCities(long stateId);
    }
}
