using BussesRouteMiniProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BussesRouteMiniProject.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            this._busService = busService;
        }
        public async Task<IActionResult> ShowAll()
        {
            var busses = await _busService.GetAllBussesAsync();
            return View(busses);
        }
    }
}
