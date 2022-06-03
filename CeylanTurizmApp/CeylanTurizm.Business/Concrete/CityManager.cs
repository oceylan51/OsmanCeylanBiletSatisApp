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
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void Create(City entity)
        {
            _cityRepository.Create(entity);
        }

        public void Delete(City entity)
        {
            _cityRepository.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        public List<City> GetCityByCityName(string name)
        {
            return _cityRepository.GetCityByCityName(name);

        }

        public void Update(City entity)
        {
            _cityRepository.Update(entity);
        }
    }
}
