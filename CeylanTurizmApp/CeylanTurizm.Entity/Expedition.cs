using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Entity
{
    public class Expedition
    {
        public int ExpeditionId { get; set; }
        public int BusId { get; set; }
        public string ExpeditionStart { get; set; }
        public string ExpeditionStation { get; set; }
        public string ExpeditionFinish { get; set; }
        public string ExpeditionDate { get; set; }
        public string ExpeditionHour { get; set; }
        public decimal ExpeditionPrice { get; set; }
        public Bus Bus { get; set; }
        public List<TicketSales> TicketSales { get; set; }
        public bool IsActive { get; set; }
        public bool IsFinish { get; set; }
        //public int ExpeditionSeatId { get; set; }
    }
}
