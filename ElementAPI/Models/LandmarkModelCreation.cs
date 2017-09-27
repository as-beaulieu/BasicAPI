using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Models
{
    //Use different models for Creating, for updating, and returning resources
    public class LandmarkModelCreation
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
