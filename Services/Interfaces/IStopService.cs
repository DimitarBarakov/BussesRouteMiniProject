using BussesRouteMiniProject.Services.Services.Models;
using BussesRouteMiniProject.ViewModels;

namespace BussesRouteMiniProject.Services.Interfaces
{
    public interface IStopService
    {
        public Task<List<StopsByBusIdViewModel>> GetStopsByBusIdAsync(int busId);
        public Task<List<AllBussesViewModel>> GetRouteAsync(StopsSearchModel model);
    }
}
