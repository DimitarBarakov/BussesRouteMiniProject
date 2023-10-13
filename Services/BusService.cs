using BussesRouteMiniProject.Data;
using BussesRouteMiniProject.Services.Interfaces;
using BussesRouteMiniProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BussesRouteMiniProject.Services
{
    public class BusService : IBusService
    {
        private readonly BussesRouteDbContext _context;

        public BusService(BussesRouteDbContext context)
        {
            _context = context;
        }
        public async Task<List<AllBussesViewModel>> GetAllBussesAsync()
        {
            var busses = await _context.Busses.Select(b=> new AllBussesViewModel()
            {
                Id = b.Id,
                Number = b.Number
            }).ToListAsync();

            return busses;
        }
    }
}
