using EVP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVPServiceLayer.Repository
{
   public interface ICountryRepository
    {
        List<Country> GetCountry();

    }
}
