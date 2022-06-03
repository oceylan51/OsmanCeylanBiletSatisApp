using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Concrete.EfCore
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, CeylanTurizmDbContext>, ICityRepository
    {
        public List<City> GetCityByCityName(string name)
        {
            using (var context = new CeylanTurizmDbContext())
            {
                var city = context.Cities.Where(x => x.CityName == name).ToList();
                return city;
            }
        }
    }
}
