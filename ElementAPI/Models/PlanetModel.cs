using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Models
{
    public class PlanetModel
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public UInt64 Distance { get; set; } //In Kilometers
        public float Orbit { get; set; } //In Years
        public float SolarDay { get; set; } //In days
        public float Radius { get; set; } //In Kilometers
        public double Mass { get; set; } //In Kilograms
        public float Gravity { get; set; } //In m/s^2
        public int NumberOfMoons { get
            {
                return Moons.Count;
            }
        }

        public ICollection<MoonModel> Moons { get; set; }
            = new List<MoonModel>();

    }
}
