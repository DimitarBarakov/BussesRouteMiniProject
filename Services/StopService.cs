using BussesRouteMiniProject.Data;
using BussesRouteMiniProject.Services.Interfaces;
using BussesRouteMiniProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BussesRouteMiniProject.Services
{
    public class StopService : IStopService
    {
        private readonly BussesRouteDbContext _context;

        public StopService(BussesRouteDbContext context)
        {
            _context = context;
        }
        public async Task<List<StopsByBusIdViewModel>> GetStopsByBusIdAsync(int busId)
        {
            var bus = await _context.Busses.FindAsync(busId);

            var busStops = await _context.BussesStops
                .Where(bs => bs.BussId == busId)
                .Select(bs => new StopsByBusIdViewModel()
                {
                    Number = bs.Stop.Number,
                    Location = bs.Stop.Location,
                    Name = bs.Stop.Name,
                    BusNumber = int.Parse(bus.Number)
                })
                .ToListAsync();

            return busStops;
        }
    }
}
