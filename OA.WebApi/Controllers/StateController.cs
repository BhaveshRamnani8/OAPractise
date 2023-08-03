using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OA.WebApi.DTO;

namespace OA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private IStateService _stateService;
        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet("countryId")]
        public IEnumerable<State> Get(int countryId)
        {
            return _stateService.GetStates(countryId);
        }        
    }
}
