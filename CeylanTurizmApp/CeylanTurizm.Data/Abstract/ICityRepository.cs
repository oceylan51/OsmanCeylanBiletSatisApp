using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Abstract
{
    public interface ICityRepository : IRepository<City>
    {
        List<City> GetCityByCityName(string name);
    }
}
