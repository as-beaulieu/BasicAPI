using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int NumberofLandmarks{ get
            {
                return Landmarks.Count;
            } 
        }
        public ICollection<LandmarkModel> Landmarks { get; set; }
            = new List<LandmarkModel>();
        
    }
}
