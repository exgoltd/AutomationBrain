using System;

namespace AutomationBrain.Entities
{
    internal partial class Device : IDevice
    {
        internal Device(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Ip { get; set; }

        public DeviceStatus Status { get; set; }
    }
}