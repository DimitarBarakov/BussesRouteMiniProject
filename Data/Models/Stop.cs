using System.ComponentModel.DataAnnotations;

namespace BussesRouteMiniProject.Data.Models
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Required]
        public string Number { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;

        public virtual List<BussesStops> Busses { get; set; } = new List<BussesStops>();
    }
}
