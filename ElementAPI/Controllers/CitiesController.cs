﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElementAPI.Data;
using ElementAPI.Models;

namespace ElementAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(CityDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //find element
            var city = CityDataStore.Current.Cities
                            .FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

        [HttpPost("{cityId}/landmarks", Name = "GetLandmark")]
        public IActionResult CreateLandmark (int cityId,
            [FromBody] LandmarkModelCreation landmark)
        {
            if(cityId == null)
            {
                return BadRequest();
            }

            var city = CityDataStore.Current.Cities
                            .FirstOrDefault(c => c.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }

            //Posting ID #
            var maxLandmarkId = CityDataStore.Current.Cities
                            .SelectMany(c => c.Landmarks)
                            .Max(p => p.Id);

            //Creating new Landmark data
            var inputNewLandmark = new LandmarkModel()
            {
                Id = ++maxLandmarkId,
                Name = landmark.Name,
                Description = landmark.Description
            };

            //Adding Landmark to City
            city.Landmarks.Add(inputNewLandmark);

            return CreatedAtRoute(
                "GetLandmark",
                new
                {
                    cityId = cityId,
                    id = inputNewLandmark.Id,
                    inputNewLandmark
                });
        }
    }
}