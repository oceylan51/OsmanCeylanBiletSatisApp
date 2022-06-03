using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Abstract
{
    public interface IBusRepository : IRepository<Bus>
    {
        //Bus Tablosuna Özel Bie Metot Gerekirse Buraya Yazılacak. 
        Bus GetBusByDriver(string name);
        List<Bus> GetBusByActive();
        List<Bus> GetBusesByDelete();
        void BusDelete(int id);
        void BusExpeditionStart(int id);
        void BusExpeditionFinish(int id);
    }
}
