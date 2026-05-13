using FollowingServerBL.Dto;
using FollowingServerBL.Services;
using Microsoft.AspNetCore.Mvc;

namespace FollowingServerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   
    public class CountryController : ControllerBase
    {

        //private readonly CountryService _service;

        //public CountryController(CountryService service)
        //{
        //    _service = service;
        //}

        //[HttpGet("Countries")]
        //public async Task<IActionResult> GetCountries()
        //{
        //    var result = await _service.GetAllCountriesAsync();
        //    return Ok(result);
        //}

        //[HttpGet("Cities")]
        //public async Task<IActionResult> GetCities()
        //{
        //    var result = await _service.GetAllCitiesAsync();
        //    return Ok(result);
        //}

        //[HttpPost("AddCity")]
        //public async Task<IActionResult> AddCity([FromBody] CityDto city)
        //{
        //    var result = await _service.AddCityAsync(city);
        //    return Created();
        //}

        //[HttpPost("AddCountry")]
        //public async Task<IActionResult> AddCountry([FromBody] CountryDto country)
        //{
        //    var result = await _service.AddCountryAsync(country);
        //    return Created();
        //}
    }
}
