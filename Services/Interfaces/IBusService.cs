using BussesRouteMiniProject.ViewModels;

namespace BussesRouteMiniProject.Services.Interfaces
{
    public interface IBusService
    {
        public Task<List<AllBussesViewModel>> GetAllBussesAsync();
    }
}
