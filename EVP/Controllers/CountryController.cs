using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVPServiceLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountryRepository _ICountryRepository;
        public CountryController(ICountryRepository iCountryRepository)
        {
            _ICountryRepository = iCountryRepository;
        }
        public IActionResult GetCountry()
        {
            var countries = _ICountryRepository.GetCountry();
            return Ok(countries);
            // return _ICountryRepository
            //List<Country> Countrylist = new List<Country>();

            //using (var DBModel = new EmployeeVarificationProjectContext())
            //{
            //    Countrylist = DBModel.Country.ToList();

            //}


        }

    }
}