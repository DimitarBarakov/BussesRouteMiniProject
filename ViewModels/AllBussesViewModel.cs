using BussesRouteMiniProject.Data.Models;

namespace BussesRouteMiniProject.ViewModels
{
    public class AllBussesViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;

        public List<Stop> Stops { get; set; } = null!;
    }
}
