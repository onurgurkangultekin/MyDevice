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
                new Device{Id=1, Name="OC2", IpAddress="192.168.74.1", Type=DeviceType.OC2},
                new Device{Id=2, Name="IPC427D", IpAddress="192.168.74.2", Type=DeviceType.IPC},
                new Device{Id=3, Name="IPC627D", IpAddress="192.168.74.3", Type=DeviceType.IPC},
            };
        }
        public IEnumerable<Device> GetAll()
        {
            return devices.OrderBy(p => p.IpAddress);
        }
    }
}
