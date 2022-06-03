using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Concrete
{
    public class TicketSalesManager : ITicketSalesService
    {
        private ITicketSalesRepository _ticketSalesRepository;

        public TicketSalesManager(ITicketSalesRepository ticketSalesRepository)
        {
            _ticketSalesRepository = ticketSalesRepository;
        }

        public void Create(TicketSales entity)
        {
            throw new NotImplementedException();
        }

        public void TicketSale(TicketSales sales)
        {
            _ticketSalesRepository.TicketSale(sales);
        }

        public void Delete(TicketSales entity)
        {
            throw new NotImplementedException();
        }

        public List<TicketSales> GetAll()
        {
            return _ticketSalesRepository.GetAll();
        }

        public TicketSales GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TicketSales entity)
        {
            throw new NotImplementedException();
        }

        public TicketSales GetTicketSalesById(int id)
        {
            return _ticketSalesRepository.GetTicketSalesById(id);
        }

        public TicketSales TicketFound(int id, string tcNo)
        {
            return _ticketSalesRepository.TicketFound(id, tcNo);
        }
    }
}
