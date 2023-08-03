using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OA.WebApi.DTO;

namespace OA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
             _countryService= countryService;
        }

        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryService.GetCountries();
        }
    }
}
