using System;

namespace AutomationBrain.Entities
{
    public interface IDevice
    {
        string Name {get; set;}

        string Ip {get; set;}
        
        DeviceStatus Status { get; set; }
    }
}