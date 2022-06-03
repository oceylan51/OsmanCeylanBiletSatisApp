using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class ExpeditionModel
    {
        [Required]
        public int ExpeditionId { get; set; }
        [Required]
        public int BusId { get; set; }
        [Required]
        public string ExpeditionStart { get; set; }
        [Required]
        public string ExpeditionStation { get; set; }
        [Required]
        public string ExpeditionFinish { get; set; }
        [Required]
        public string ExpeditionDate { get; set; }
        [Required]
        public string ExpeditionHour { get; set; }
        [Required]
        public decimal ExpeditionPrice { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsFinish { get; set; }
    }
}
