using BussesRouteMiniProject.Data.Models;
using BussesRouteMiniProject.ViewModels;

namespace BussesRouteMiniProject.Services.Services.Models
{
    public class StopsSearchModel
    {
        public string StartingStop { get; set; } = null!;
        public string FinalStop { get; set; } = null!;

        public List<AllBussesViewModel> Busses { get; set; } = new List<AllBussesViewModel>();
    }
}
