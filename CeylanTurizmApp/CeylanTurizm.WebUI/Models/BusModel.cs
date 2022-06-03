using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class BusModel
    {
        [Required]
        public int BusId { get; set; }
        [Required]
        public string BusPlaque { get; set; }
        [Required]
        public string BusDriver { get; set; }
        [Required]
        public int BusSeatingCapacity { get; set; }

    }
}
