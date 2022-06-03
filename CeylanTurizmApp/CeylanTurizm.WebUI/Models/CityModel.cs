using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class CityModel
    {
        [Required]
        public int CityId { get; set; }
        [Required]
        public int CityNo { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string CityImg { get; set; }
        [Required]
        public string CityTitle { get; set; }
        [Required]
        public string CityDescription { get; set; }
        [Required]
        public string CityDescription2 { get; set; }
        [Required]
        public string CityDescription3 { get; set; }
        [Required]
        public string CityDescription4 { get; set; }
        [Required]
        public string CityDescription5 { get; set; }
    }
}
