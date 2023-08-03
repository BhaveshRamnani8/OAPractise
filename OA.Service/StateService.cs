using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class StateService : IStateService
    {
        private IStateRepo _repo;
        public StateService(IStateRepo stateRepo)
        {
            _repo = stateRepo;
        }
        public IEnumerable<State> GetStates(long countryId)
        {
            return _repo.GetStates(countryId);
        }
    }
}
