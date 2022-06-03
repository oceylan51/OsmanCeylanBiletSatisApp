using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Abstract
{
    public interface IExpeditionRepository : IRepository<Expedition>
    {
        List<Expedition> GetExpeditionByActiveAndFinish();
        List<Expedition> GetExpeditionByDeleted();
        List<Expedition> GetExpeditionByFinished();
        int GetBusIdByExpeditionId(int id);
        void ExpeditionFinish(int id);
        void ExpeditionDelete(int id);
        List<Expedition> GetExpeditionsByExpeditionFinish(string cityStart, string cityFinish, string date);
        //int GetBusSeatingCapacityByBusId(int id);
    }
}
