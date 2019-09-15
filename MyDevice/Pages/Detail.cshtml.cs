using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyDevice.Core;
using MyDevice.Data;

namespace MyDevice.Pages
{
    public class DetailModel : PageModel
    {
        private readonly IDeviceData deviceData;

        public Device Device { get; set; }
        public DetailModel(IDeviceData deviceData)
        {
            this.deviceData = deviceData;
        }
        public IActionResult OnGet(int deviceId)
        {
            Device = deviceData.GetDevicesById(deviceId);
            if (Device == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}