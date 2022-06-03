using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class TicketSalesModel
    {
        public int TicketSalesId { get; set; }
        public int ExpeditionId { get; set; }
        public Expedition Expedition { get; set; }
        [Required(ErrorMessage ="Lütfen koltuk seçiniz")]
        public int SeatNumber { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerTelNo { get; set; }
        public string customerTcNo { get; set; }
    }
}
