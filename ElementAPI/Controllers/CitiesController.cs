using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElementAPI.Data;
using ElementAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Logging;

namespace ElementAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ILogger<CitiesController> _logger;

        public CitiesController(ILogger<CitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(CityDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                //find element
                var city = CityDataStore.Current.Cities
                                .FirstOrDefault(c => c.Id == id);
                if (city == null)
                {
                    _logger.LogInformation($"City with id {id} wasn't found."); //String interpolation
                    return NotFound();
                }
                return Ok(city);
            }
            catch(Exception e)
            {
                _logger.LogCritical($"Exception while getting cities with id {id}.", e);
                return StatusCode(500, "A problem happened while handling your request");//Caution! This information will go to the user
            }
            
        }

        [HttpPost("{cityId}/landmarks", Name = "GetLandmark")]
        public IActionResult CreateLandmark (int cityId,
            [FromBody] LandmarkModelCreation landmark)
        {
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
        //END CreateLandmark()

        [HttpPut("{cityId}/landmarks/{landmarkId}")]
        public IActionResult UpdateLandmarkAll(
            int cityId, 
            int landmarkId,
            [FromBody] LandmarkModelUpdate landmark)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = CityDataStore.Current.Cities
                            .FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var landmarkFromData = city.Landmarks
                                        .FirstOrDefault(l => l.Id == landmarkId);

            if(landmarkFromData == null)
            {
                return NotFound();
            }

            landmarkFromData.Name = landmark.Name;
            landmarkFromData.Description = landmark.Description;

            return NoContent();
        }
        //END UpdateLandmarkAll();


        //Remember: JSON for patch request needs both brackets: [{"op":"replace","path":"/(key)","value":(value)}]
        [HttpPatch("{cityId}/landmarks/{landmarkId}")]
        public IActionResult UpdateLandmarkPartial(
            int cityId,
            int landmarkId,
            [FromBody] JsonPatchDocument<LandmarkModelUpdate> patchDoc)
        {
            if(patchDoc == null)
            {
                return BadRequest();
            }

            var city = CityDataStore.Current.Cities
                                    .FirstOrDefault(c => c.Id == cityId);
            if(city == null)
            {
                return NotFound();
            }

            var landmarkFromData = city.Landmarks
                                        .FirstOrDefault(l => l.Id == landmarkId);
            if(city == null)
            {
                return NotFound();
            }

            var landmarkToPatch = new LandmarkModelUpdate()
            {
                Name = landmarkFromData.Name,
                Description = landmarkFromData.Description,
            };

            //
            patchDoc.ApplyTo(landmarkToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            landmarkFromData.Name = landmarkToPatch.Name;
            landmarkFromData.Description = landmarkToPatch.Description;

            return NoContent();
        }
        //END UpdateLandmarkPartial()

        [HttpDelete("{cityId}/landmarks/{landmarkId}")]
        public IActionResult DeleteLandmark(
            int cityId,
            int landmarkId)
        {
            var city = CityDataStore.Current.Cities
                                    .FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var landmarkFromData = city.Landmarks
                                        .FirstOrDefault(l => l.Id == landmarkId);
            if (city == null)
            {
                return NotFound();
            }

            city.Landmarks.Remove(landmarkFromData);

            return NoContent();
        }
        //END DeleteLandmark()
    }
}