using System;

namespace MyDevice.Core
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public DeviceType Type { get; set; }
    }
}
