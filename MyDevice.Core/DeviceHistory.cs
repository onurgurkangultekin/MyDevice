using System;
using System.Collections.Generic;
using System.Text;

namespace MyDevice.Core
{
    public class DeviceHistory
    {
        public int DeviceId { get; set; }
        public string User { get; set; }
        public DateTime ActionTime { get; set; }
        public string Description { get; set; }
    }
}
