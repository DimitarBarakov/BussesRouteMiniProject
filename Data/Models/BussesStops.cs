using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussesRouteMiniProject.Data.Models
{
    public class BussesStops
    {
        [Required]
        [ForeignKey(nameof(Bus))]
        public int BussId { get; set; }
        public virtual Bus Bus { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Stop))]
        public int StopId { get; set; }
        public virtual Stop Stop { get; set; } = null!;
    }
}
