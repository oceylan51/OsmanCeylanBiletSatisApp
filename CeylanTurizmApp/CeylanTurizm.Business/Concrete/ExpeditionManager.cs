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
    public class ExpeditionManager : IExpeditionService
    {
        private IExpeditionRepository _expeditionRepository;

        public ExpeditionManager(IExpeditionRepository expeditionRepository)
        {
            _expeditionRepository = expeditionRepository;
        }

        public void Create(Expedition entity)
        {
            _expeditionRepository.Create(entity);
        }

        public void Delete(Expedition entity)
        {
            throw new NotImplementedException();
        }

        public void ExpeditionDelete(int id)
        {
            _expeditionRepository.ExpeditionDelete(id);
        }

        public void ExpeditionFinish(int id)
        {
            _expeditionRepository.ExpeditionFinish(id);
        }

        public List<Expedition> GetAll()
        {
            return _expeditionRepository.GetAll();
        }

        public int GetBusIdByExpeditionId(int id)
        {
            return _expeditionRepository.GetBusIdByExpeditionId(id);
        }

        public Expedition GetById(int id)
        {
            return _expeditionRepository.GetById(id);
        }

        public List<Expedition> GetExpeditionByActiveAndFinish()
        {
            return _expeditionRepository.GetExpeditionByActiveAndFinish();
        }

        public List<Expedition> GetExpeditionByDeleted()
        {
            return _expeditionRepository.GetExpeditionByDeleted();
        }

        public List<Expedition> GetExpeditionByFinished()
        {
            return _expeditionRepository.GetExpeditionByFinished();
        }

        public List<Expedition> GetExpeditionsByExpeditionFinish(string cityStart, string cityFinish, string date)
        {
            return _expeditionRepository.GetExpeditionsByExpeditionFinish(cityStart, cityFinish, date);
        }

        public void Update(Expedition entity)
        {
            _expeditionRepository.Update(entity);
        }
    }
}
