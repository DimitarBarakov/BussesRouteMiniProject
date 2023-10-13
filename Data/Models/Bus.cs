using System.ComponentModel.DataAnnotations;

namespace BussesRouteMiniProject.Data.Models
{
    public class Bus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; } = null!;

        public virtual List<BussesStops> Stops { get; set; } = new List<BussesStops>();
    }
}
