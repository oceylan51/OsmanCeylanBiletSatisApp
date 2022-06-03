using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Concrete.EfCore
{
    public class EfCoreTicketSalesRepository : EfCoreGenericRepository<TicketSales, CeylanTurizmDbContext>, ITicketSalesRepository
    {
        public TicketSales GetTicketSalesById(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.TicketSales
                    .Include(x => x.Expedition)
                    .ThenInclude(x => x.Bus)
                    .First(x => x.TicketSalesId == id);
            }
        }

        public TicketSales TicketFound(int id, string tcNo)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.TicketSales
                    .Where(x => x.TicketSalesId == id && x.customerTcNo == tcNo)
                    .Include(x => x.Expedition)
                    .ThenInclude(x => x.Bus)
                    .FirstOrDefault();
            }
        }

        public void TicketSale(TicketSales sales)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                context.TicketSales.Add(sales);
                context.SaveChanges();
            }
        }
    }
}
