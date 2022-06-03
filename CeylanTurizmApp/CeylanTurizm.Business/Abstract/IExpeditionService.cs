using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Abstract
{
    public interface IExpeditionService : IRepository<Expedition>
    {
        List<Expedition> GetExpeditionByActiveAndFinish();
        List<Expedition> GetExpeditionsByExpeditionFinish(string cityStart, string cityFinish, string date);
        void ExpeditionFinish(int id);
        void ExpeditionDelete(int id);
        int GetBusIdByExpeditionId(int id);
        List<Expedition> GetExpeditionByDeleted();
        List<Expedition> GetExpeditionByFinished();


    }
}
