using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Abstract
{
    public interface ITicketSalesService : IRepository<TicketSales>
    {
        void TicketSale(TicketSales sales);
        TicketSales GetTicketSalesById(int id);
        TicketSales TicketFound(int id, string tcNo);

    }
}
