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
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public void BusDelete(int id)
        {
            _busRepository.BusDelete(id);
        }

        public void BusExpeditionFinish(int id)
        {
            _busRepository.BusExpeditionFinish(id);
        }

        public void BusExpeditionStart(int id)
        {
            _busRepository.BusExpeditionStart(id);
        }

        public void Create(Bus entity)
        {
            _busRepository.Create(entity);
        }

        public void Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetAll()
        {
            return _busRepository.GetAll();
        }

        public List<Bus> GetBusByActive()
        {
            return _busRepository.GetBusByActive();
        }

        public List<Bus> GetBusesByDelete()
        {
            return _busRepository.GetBusesByDelete();
        }

        public Bus GetById(int id)
        {
            return _busRepository.GetById(id);
        }

        public void Update(Bus entity)
        {
            _busRepository.Update(entity);
        }
    }
}
