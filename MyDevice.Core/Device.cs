using System;

namespace MyDevice.Core
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public DeviceType Type { get; set; }
        public DetailedDeviceType DetailedDeviceType { get; set; }
        public DeviceStatus Status { get; set; }
        public string User { get; set; }
        public string Version { get; set; }
    }
}
