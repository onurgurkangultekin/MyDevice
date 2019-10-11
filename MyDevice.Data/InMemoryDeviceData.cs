using MyDevice.Core;
using System.Collections.Generic;
using System.Linq;

namespace MyDevice.Data
{
    public class InMemoryDeviceData : IDeviceData
    {
        List<Device> devices;

        public InMemoryDeviceData()
        {
            devices = new List<Device>
            {
                new Device{Id=1, Name="OC2", IpAddress="192.168.74.1", Type=DeviceType.OC, Version="V2.5"},
                new Device{Id=2, Name="IPC427D", IpAddress="192.168.74.2", Type=DeviceType.IPC, Version="V2.7"},
                new Device{Id=3, Name="IPC627D", IpAddress="192.168.74.3", Type=DeviceType.IPC, Version="V2.6"},
                new Device{Id=4, Name="CTSNZ0068", IpAddress="192.168.74.21", Type=DeviceType.TestPC, },
                new Device{Id=5, Name="EVT000133", IpAddress="192.168.74.31", Type=DeviceType.Laptop, },
            };
        }

        public Device GetDevicesById(int deviceId)
        {
            return devices.SingleOrDefault(p => p.Id == deviceId);
        }

        public IEnumerable<Device> GetDevicesByName(string name = null)
        {
            return devices.OrderBy(p => p.IpAddress).Where(p => string.IsNullOrWhiteSpace(name) ||
                                                                p.Name.StartsWith(name));
        }
    }
}
