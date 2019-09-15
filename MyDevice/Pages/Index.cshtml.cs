using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MyDevice.Core;
using MyDevice.Data;

namespace MyDevice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IDeviceData deviceData;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public IEnumerable<Device> Devices { get; set; }

        public IndexModel(IConfiguration config, IDeviceData deviceData)
        {
            this.config = config;
            this.deviceData = deviceData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Devices = deviceData.GetDevicesByName(SearchTerm);
        }
    }
}
