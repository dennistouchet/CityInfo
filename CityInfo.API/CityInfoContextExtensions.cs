using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var Cities = new List<City>() {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with the big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urbain park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper in Midtown."
                        }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathedral they never finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Cethedral of Our Lady",
                            Description = "Gothic style cathedral"
                        },
                        new PointOfInterest()
                        {
                            Name = "Antwerp Central Station",
                            Description = "A fine railway structure"
                        }
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with the point tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "The Eiffel Town",
                            Description = "A wrought iron lattice tower"
                        },
                        new PointOfInterest()
                        {
                            Name = "The Louvre",
                            Description = "The world's Largest museum."
                        }
                    }
                }
            };

            context.Cities.AddRange(Cities);
            context.SaveChanges();
        }
    }
}
