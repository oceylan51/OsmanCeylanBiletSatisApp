using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Abstract
{
    public interface ICityService : IRepository<City>
    {
        List<City> GetCityByCityName(string name);
    }
}
