using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class CityListViewModel
    {
        public Sales Sales { get; set; }
        public List<City> CitiesAll { get; set; }
        public List<City> CitiesByCityName { get; set; }
    }
    public class Sales
    {
        public string cityStart { get; set; }
        public string cityFinish { get; set; }
        public string date { get; set; }
    }
}
