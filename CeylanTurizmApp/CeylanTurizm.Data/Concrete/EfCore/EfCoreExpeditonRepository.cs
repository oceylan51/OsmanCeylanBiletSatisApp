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
    public class EfCoreExpeditonRepository : EfCoreGenericRepository<Expedition, CeylanTurizmDbContext>, IExpeditionRepository
    {
        public void ExpeditionDelete(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                context.Expeditions.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }

        public void ExpeditionFinish(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                context.Expeditions.Find(id).IsFinish = true;
                context.SaveChanges();
            }
        }

        public int GetBusIdByExpeditionId(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                var a = int.Parse(context.Expeditions.Where(x => x.ExpeditionId == id).Select(x => x.BusId).FirstOrDefault().ToString());
                return a;
            }
        }

        public List<Expedition> GetExpeditionByActiveAndFinish()
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Expeditions.Include(x => x.Bus)
                    .Where(x => x.IsActive == false && x.IsFinish == false).ToList();
            }
        }

        public List<Expedition> GetExpeditionByDeleted()
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Expeditions.Include(x => x.Bus)
                    .Where(x => x.IsActive == true).ToList();
            }
        }

        public List<Expedition> GetExpeditionByFinished()
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Expeditions.Include(x => x.Bus)
                    .Where(x => x.IsFinish == true).ToList();
            }
        }

        public List<Expedition> GetExpeditionsByExpeditionFinish(string cityStart, string cityFinish, string date)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Expeditions.Include(x => x.Bus)
                    .Where(x => ((x.ExpeditionStart == cityStart || x.ExpeditionStation == cityStart)
                    && (x.ExpeditionFinish == cityFinish || x.ExpeditionStation == cityFinish)) && x.ExpeditionDate == date && x.IsActive == false && x.IsActive == false).ToList();
            }
        }
    }
}
