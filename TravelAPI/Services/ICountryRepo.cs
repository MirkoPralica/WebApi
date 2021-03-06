﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TravelAPI.Models;

namespace TravelAPI.Services
{
    public interface ICountryRepo : IRepository
    {
        Task<ICollection<CountryModel>> GetCountries(
            bool includeCities = false,
            bool includeTravelRestrictions = false,
            bool includeAttractions = false,
            int attractionsMinRating = 0,
            int attractionsMaxRating = 5
            );

        Task<CountryModel> GetCountry(
            string name,
            bool includeCities = false,
            bool includeTravelRestrictions = false,
            bool includeAttractions = false,
            int attractionsMinRating = 0,
            int attractionsMaxRating = 5
            );

        Task<CountryModel> GetCountry(
            int id,
            bool includeCities = false,
            bool includeTravelRestrictions = false,
            bool includeAttractions = false,
            int attractionsMinRating = 0,
            int attractionsMaxRating = 5
            );

        Task<ICollection<CountryModel>> GetRightHandTraffic(bool rightHandTraffic);

        Task<ICollection<CountryModel>> GetCountriesByLanguage(string language);
    }
}
