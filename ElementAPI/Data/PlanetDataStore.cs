using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementAPI.Models;

namespace ElementAPI.Data
{
    public class PlanetDataStore
    {
        public static PlanetDataStore Current { get; } = new PlanetDataStore();
        public List<PlanetModel> Planets { get; set; }

        public PlanetDataStore()
        {
            Planets = new List<PlanetModel>()
            {
                new PlanetModel()
                {
                    Position = 1,
                    Name = "Mercury",
                    Distance = 57909050, //In Kilometers
                    Orbit = 0.240846F, //In years
                    SolarDay = 0.5F, //In Days
                    Radius = 2439, //In Kilometers
                    Mass = 3.3011E23, //In Kilograms
                    Gravity = 3.7F, //In m/s^2
                },
                new PlanetModel()
                {
                    Position = 2,
                    Name = "Venus",
                    Distance = 108208000, //In Kilometers
                    Orbit = 0.615198F, //In years
                    SolarDay = 1.92F, //In Days
                    Radius = 6051.8F, //In Kilometers
                    Mass = 4.8675E24, //4.8675x10^24 kg
                    Gravity = 8.87F, //In m/s^2
                },
                new PlanetModel()
                {
                    Position = 3,
                    Name = "Earth",
                    Distance = 149598023, //In Kilometers
                    Orbit = 1.00001742096F, //In years
                    SolarDay = 1.0F, //In Days
                    Radius = 6371.0F, //In Kilometers
                    Mass = 5.97237E24, //In Kilograms
                    Gravity = 9.807F, //In m/s^2
                    Moons = new List<MoonModel>()
                    {
                        new MoonModel()
                        {
                            Position = 1,
                            Name = "The Moon",
                            Description = "Some text"
                        }
                    }
                },
                new PlanetModel()
                {
                    Position = 4,
                    Name = "Mars",
                    //Distance = , //In Kilometers
                    Orbit = 1.8808F, //In years
                    //SolarDay = F, //In Days
                    Radius = 2289.5F, //In Kilometers
                    Mass = 6.4171E23, //In Kilograms
                    Gravity = 3.711F, //In m/s^2
                    Moons = new List<MoonModel>()
                    {
                        new MoonModel()
                        {
                            Position = 1,
                            Name = "Phobos",
                            Description = "Some text"
                        },
                        new MoonModel()
                        {
                            Position = 2,
                            Name = "Deimos",
                            Description = "Some text"
                        },
                    }
                },
                new PlanetModel()
                {
                    Position = 5,
                    Name = "Jupiter",
                    //Distance = , //In Kilometers
                    Orbit = 11.8618F, //In years
                    //SolarDay = F, //In Days
                    Radius = 69911.0F, //In Kilometers
                    Mass = 1.8986E27, //In Kilograms
                    Gravity = 24.79F, //In m/s^2
                    Moons = new List<MoonModel>()
                    {
                        new MoonModel()
                        {
                            Position = 1,
                            Name = "Metis",
                            Description = "Discovered by Voyager I"
                        },
                        new MoonModel()
                        {
                            Position = 2,
                            Name = "Adrastea",
                            Description = "Discovered by Voyager 2"
                        },
                        new MoonModel()
                        {
                            Position = 3,
                            Name = "Amalthea",
                            Description = "Some text"
                        },
                    }
                },

            };
        }
    }
}
