using System;
using AutomationBrain.Entities;

namespace AutomationBrain.Services
{
    public static class DeviceService
    {
        public static IDevice Get(string name)
        {
            return new Device("Test Location");
        }

        public static void Add(IDevice Device)
        {

        }

        public static void Update(IDevice Device)
        {

        }

        public static void Delete(string name)
        {
            
        }
    }
}