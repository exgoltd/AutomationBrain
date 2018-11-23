using System;
using AutomationBrain.Entities;

namespace AutomationBrain.Services
{
    public static class LocationService
    {
        public static ILocation Get(string name)
        {
            return new Location("Test Location");
        }

        public static void Add(ILocation location)
        {

        }

        public static void Update(ILocation location)
        {

        }

        public static void Delete(string name)
        {
            
        }
    }
}