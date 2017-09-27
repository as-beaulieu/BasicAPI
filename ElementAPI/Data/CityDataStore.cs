using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementAPI.Models;

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
    }
}

