using BussesRouteMiniProject.Services.Interfaces;
using BussesRouteMiniProject.Services.Services.Models;
using BussesRouteMiniProject.ViewModels;
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
        public async Task<IActionResult> ShowRoute([FromQuery]StopsSearchModel model)
        {
            List<AllBussesViewModel> busses = await stopService.GetRouteAsync(model);
            model.Busses = busses;
            return View(model);
        }
    }
}
