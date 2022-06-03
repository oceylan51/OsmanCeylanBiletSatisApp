using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Abstract
{
    public interface ITicketSalesRepository : IRepository<TicketSales>
    {
        //Ticket Sales Tablosuna Özel Bir Metot Olursa Buraya Yazılacak.
        void TicketSale(TicketSales sales);
        TicketSales GetTicketSalesById(int id);
        TicketSales TicketFound(int id, string tcNo);
    }
}
