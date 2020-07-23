using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVP.Models;

namespace EVPServiceLayer.Repository
{
    public class CountryRepository : ICountryRepository
    {
        
            EmployeeVarificationProjectContext employeeVarification;
            public CountryRepository(EmployeeVarificationProjectContext _employeeVarification)
            {
                employeeVarification = _employeeVarification;
            }
           
            public List<Country> GetCountry()
            {
                return employeeVarification.Country.ToList();
            }

        
    }
}
