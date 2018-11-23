using System;

namespace AutomationBrain.Entities
{
    internal class Location : ILocation
    {
        internal Location(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}