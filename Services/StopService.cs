using BussesRouteMiniProject.Data;
using BussesRouteMiniProject.Data.Models;
using BussesRouteMiniProject.Services.Interfaces;
using BussesRouteMiniProject.Services.Services.Models;
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

        public async Task<List<AllBussesViewModel>> GetRouteAsync(StopsSearchModel model)
        {
            var busses = _context.Busses;
            foreach (var bus in busses)
            {
                bus.Stops = await _context.BussesStops.Where(bs => bs.BussId == bus.Id).Select(bs=>new BussesStops()
                {
                    Stop = bs.Stop
                }).ToListAsync();
            }
            List<AllBussesViewModel> bussesToReturn = new List<AllBussesViewModel>();

            if (!String.IsNullOrEmpty(model.StartingStop) && !String.IsNullOrEmpty(model.FinalStop))
            {
                string startingStopWildCard = model.StartingStop.ToLower();
                string finalStopWildCard = model.FinalStop.ToLower();
                foreach (var bus in busses)
                {

                    if (bus.Stops.Any(s => s.Stop.Name.ToLower().Contains(startingStopWildCard))
                        && bus.Stops.Any(s => s.Stop.Name.ToLower().Contains(finalStopWildCard)))
                    {
                        AllBussesViewModel busToAdd = new AllBussesViewModel()
                        {
                            Id = bus.Id,
                            Stops = bus.Stops.Select(s => new Stop
                            {
                                Id = s.Stop.Id,
                                Number = s.Stop.Number,
                                Name = s.Stop.Name,
                                Location = s.Stop.Location
                            }).ToList(),
                            Number = bus.Number
                        };
                        bussesToReturn.Add(busToAdd);
                        break;
                    }
                }
            }

            return bussesToReturn;
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
