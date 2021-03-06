﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TravelAPI.Services;
using AutoMapper;
using TravelAPI.DTO;
using TravelAPI.Models;

namespace TravelAPI.Controller
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepo _countryRepo;
        private readonly IMapper _mapper;

        public CountryController(ICountryRepo countryRepo, IMapper mapper)
        {
            _countryRepo = countryRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CountryDto[]>> GetCountries(
            [FromQuery]bool includeCities = false,
            [FromQuery]bool includeTravelRestrictions = false,
            [FromQuery]bool includeAttractions = false,
            [FromQuery]int attractionsMinRating = 0,
            [FromQuery]int attractionsMaxRating = 5)
        {
            try
            {
                var results = await _countryRepo.GetCountries
                (
                    includeCities,
                    includeTravelRestrictions,
                    includeAttractions,
                    attractionsMinRating,
                    attractionsMaxRating
                );

                return Ok(results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<CountryDto>> GetCountry(
            string name,
            [FromQuery]bool includeCities = false,
            [FromQuery]bool includeTravelRestrictions = false,
            [FromQuery]bool includeAttractions = false,
            [FromQuery]int attractionsMinRating = 0,
            [FromQuery]int attractionsMaxRating = 5)
        {
            try
            {
                var results = await _countryRepo.GetCountry
                (
                    name,
                    includeCities,
                    includeTravelRestrictions,
                    includeAttractions,
                    attractionsMinRating,
                    attractionsMaxRating
                );

                return Ok(results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CountryDto>> GetCountry(
            int id,
            [FromQuery]bool includeCities = false,
            [FromQuery]bool includeTravelRestrictions = false,
            [FromQuery]bool includeAttractions = false,
            [FromQuery]int attractionsMinRating = 0,
            [FromQuery]int AttractionsMaxRating = 5)
        {
            try
            {
                var results = await _countryRepo.GetCountry
                (
                    id,
                    includeCities,
                    includeTravelRestrictions,
                    includeAttractions,
                    attractionsMinRating,
                    AttractionsMaxRating
                );

                return Ok(results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<CountryDto>> PostCountry(CountryDto countryDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<CountryModel>(countryDto);
                _countryRepo.Add(mappedEntity);

                if (await _countryRepo.Save())
                {
                    return Created($"/api/v1.0/countries/{mappedEntity.CountryId}", _mapper.Map<CountryModel>(mappedEntity));
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }

            return BadRequest();
        }
    }
}
