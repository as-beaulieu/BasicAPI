using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementAPI.Models;
using ElementAPI.Entities;

namespace ElementAPI.Data
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();

        public List<CityModel> Cities { get; set; }

        public CityDataStore() => Cities = new List<CityModel>()
        {
            new CityModel()
            {
                Id = 1,
                Name = "Denver",
                Country = "United States",
                Landmarks = new List<LandmarkModel>()
                {
                    new LandmarkModel()
                    {
                        Id = 1,
                        Name = "Downtown",
                        Description = "Lots of growth and new towers"
                    }
                }
            }
        };
        //END CityDataStore()

        public IEnumerable<CityModel> GetCities()
        {
            using (var context = new ElementAPIInfoContext())
            {
                var cityModels = new List<CityModel>();
                //Method 1: foreach
                foreach (var city in context.Cities)
                {
                    cityModels.Add(new CityModel
                    {
                        Id = city.Id,
                        Name = city.Name

                    });
                }

                //Method 2: automapper
                //Pass what my entity and model looks like, and my actual entity
                

                return cityModels;
            }
        }
        //END GetCities()
    }
}

