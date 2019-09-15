using MyDevice.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyDevice.Data
{
    public interface IDeviceData
    {
        IEnumerable<Device> GetDevicesByName(string name);
        Device GetDevicesById(int deviceId);
    }
}
