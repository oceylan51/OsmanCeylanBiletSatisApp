using CeylanTurizm.Entity;
using CeylanTurizm.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class ExpeditionandTicketSalesViewModel
    {
        public List<TicketSales> ticketSales { get; set; }
        public List<Expedition> expeditions { get; set; }
        public TicketSales sales { get; set; }
        public User User { get; set; }
    }
}
