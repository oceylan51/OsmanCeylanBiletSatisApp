using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Entity
{
    public class TicketSales
    {
        public int TicketSalesId { get; set; }
        public int ExpeditionId { get; set; }
        public Expedition Expedition { get; set; }
        public int SeatNumber { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerTelNo { get; set; }
        public string customerTcNo { get; set; }
    }
}
