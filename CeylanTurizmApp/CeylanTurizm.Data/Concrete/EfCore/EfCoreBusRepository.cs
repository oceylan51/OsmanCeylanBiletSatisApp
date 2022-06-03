using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Concrete.EfCore
{
    public class EfCoreBusRepository : EfCoreGenericRepository<Bus, CeylanTurizmDbContext>, IBusRepository
    {
        public void BusDelete(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                var bus = context.Buses.Find(id);
                bus.IsDelte = true;
                context.SaveChanges();
            }
        }

        public void BusExpeditionFinish(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                var bus = context.Buses.Find(id);
                bus.IsActive = false;
                context.SaveChanges();
            }
        }

        public void BusExpeditionStart(int id)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                context.Buses.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }

        public List<Bus> GetBusByActive()
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Buses.Where(x => x.IsDelte == false && x.IsActive == false).ToList();
            }
        }

        public Bus GetBusByDriver(string name)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetBusesByDelete()
        {
            using (var context = new CeylanTurizmDbContext())
            {
                return context.Buses.Where(x => x.IsDelte == false).ToList();
            }
        }
    }
}
