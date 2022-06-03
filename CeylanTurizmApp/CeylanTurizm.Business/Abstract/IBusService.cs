using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Abstract
{
    public interface IBusService : IRepository<Bus>
    {
        List<Bus> GetBusesByDelete();
        List<Bus> GetBusByActive();
        void BusDelete(int id);
        void BusExpeditionStart(int id);
        void BusExpeditionFinish(int id);

    }
}
