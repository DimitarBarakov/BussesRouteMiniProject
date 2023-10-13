using BussesRouteMiniProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BussesRouteMiniProject.Controllers
{
    public class StopController : Controller
    {
        private readonly IStopService stopService;

        public StopController(IStopService service)
        {
            stopService = service;
        }
        public async Task<IActionResult> ShowStopsByBusId(int id)
        {
            var stops = await stopService.GetStopsByBusIdAsync(id);

            return View(stops);
        }
    }
}
