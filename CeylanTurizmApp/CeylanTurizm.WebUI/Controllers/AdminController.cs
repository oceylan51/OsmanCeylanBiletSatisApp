using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Entity;
using CeylanTurizm.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private IBusService _busService;
        private ICityService _cityService;
        private IExpeditionService _expeditionService;

        public AdminController(IBusService busService, ICityService cityService, IExpeditionService expeditionService)
        {
            _busService = busService;
            _cityService = cityService;
            _expeditionService = expeditionService;
        }

        public IActionResult Index()
        {
            return View();
        }



        //Bus Actions Start

        public IActionResult BusList()
        {
            var buses = _busService.GetBusesByDelete();
            return View(buses);
        }
        public IActionResult BusCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BusCreate(BusModel model)
        {
            if (ModelState.IsValid)
            {
                var bus = new Bus()
                {
                    BusDriver = model.BusDriver,
                    BusPlaque = model.BusPlaque,
                    BusSeatingCapacity = model.BusSeatingCapacity
                };
                _busService.Create(bus);
                return RedirectToAction("BusList");
            }
            return View(model);
        }
        public IActionResult BusEdit(int id)
        {
            var model = _busService.GetById(id);
            BusModel busModel = new BusModel()
            {
                BusPlaque = model.BusPlaque,
                BusId = model.BusId,
                BusDriver = model.BusDriver,
                BusSeatingCapacity = model.BusSeatingCapacity
            };
            return View(busModel);
        }
        [HttpPost]
        public IActionResult BusEdit(BusModel model)
        {
            if (ModelState.IsValid)
            {
                Bus bus = new Bus()
                {
                    BusId = model.BusId,
                    BusPlaque = model.BusPlaque,
                    BusDriver = model.BusDriver,
                    BusSeatingCapacity = model.BusSeatingCapacity
                };
                _busService.Update(bus);
                return RedirectToAction("BusList");
            }
            return View(model);
        }

        public IActionResult BusDelete(int id)
        {
            _busService.BusDelete(id);
            return RedirectToAction("BusList");
        }

        //Bus Actions Finish




        //City Actions Start
        public IActionResult CityList()
        {
            return View(_cityService.GetAll());
        }

        public IActionResult CityCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CityCreate(CityModel model)
        {
            if (ModelState.IsValid)
            {
                City city = new City()
                {
                    CityNo = model.CityNo,
                    CityName = model.CityName,
                    CityImg = model.CityImg,
                    CityTitle = model.CityTitle,
                    CityDescription = model.CityDescription,
                    CityDescription2 = model.CityDescription2,
                    CityDescription3 = model.CityDescription3,
                    CityDescription4 = model.CityDescription4,
                    CityDescription5 = model.CityDescription5,
                };
                _cityService.Create(city);
                return RedirectToAction("CityList");
            }
            return View(model);
        }
        public IActionResult CityEdit(int id)
        {
            var city = _cityService.GetById(id);
            CityModel model = new CityModel()
            {
                CityId = city.CityId,
                CityNo = city.CityNo,
                CityName = city.CityName,
                CityImg = city.CityImg,
                CityTitle = city.CityTitle,
                CityDescription = city.CityDescription,
                CityDescription2 = city.CityDescription2,
                CityDescription3 = city.CityDescription3,
                CityDescription4 = city.CityDescription4,
                CityDescription5 = city.CityDescription5
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CityEdit(CityModel model)
        {
            if (ModelState.IsValid)
            {
                City city = new City()
                {
                    CityId = model.CityId,
                    CityNo = model.CityNo,
                    CityName = model.CityName,
                    CityImg = model.CityImg,
                    CityTitle = model.CityTitle,
                    CityDescription = model.CityDescription,
                    CityDescription2 = model.CityDescription2,
                    CityDescription3 = model.CityDescription3,
                    CityDescription4 = model.CityDescription4,
                    CityDescription5 = model.CityDescription5
                };
                _cityService.Update(city);
                return RedirectToAction("CityList");
            }
            return View(model);
        }
        public IActionResult CityDelete(int id)
        {
            var city = _cityService.GetById(id);
            _cityService.Delete(city);
            return RedirectToAction("CityList");
        }
        //City Actions Finish




        //Expedition Action Start
        public IActionResult ExpeditionList()
        {
            return View(_expeditionService.GetExpeditionByActiveAndFinish());
        }
        public IActionResult ExpeditionCreate()
        {
            ViewBag.Cities = new SelectList(_cityService.GetAll(), "CityName", "CityName");
            ViewBag.Buses = new SelectList(_busService.GetBusByActive(), "BusId", "BusPlaque");
            return View();
        }
        [HttpPost]
        public IActionResult ExpeditionCreate(ExpeditionModel model)
        {
            if (ModelState.IsValid)
            {
                Expedition expedition = new Expedition()
                {
                    ExpeditionStart = model.ExpeditionStart,
                    ExpeditionStation = model.ExpeditionStation,
                    ExpeditionFinish = model.ExpeditionFinish,
                    ExpeditionDate = model.ExpeditionDate,
                    ExpeditionHour = model.ExpeditionHour,
                    ExpeditionPrice = model.ExpeditionPrice,
                    BusId = model.BusId
                };
                _expeditionService.Create(expedition);
                _busService.BusExpeditionStart(model.BusId);
                return RedirectToAction("ExpeditionList");
            }
            ViewBag.Cities = new SelectList(_cityService.GetAll(), "CityName", "CityName");
            ViewBag.Buses = new SelectList(_busService.GetBusByActive(), "BusId", "BusPlaque");
            return View(model);
        }
        public IActionResult ExpeditionEdit(int id)
        {
            Expedition expedition = _expeditionService.GetById(id);
            ExpeditionModel model = new ExpeditionModel()
            {
                ExpeditionId = expedition.ExpeditionId,
                BusId = expedition.BusId,
                ExpeditionStart = expedition.ExpeditionStart,
                ExpeditionStation = expedition.ExpeditionStation,
                ExpeditionFinish = expedition.ExpeditionFinish,
                ExpeditionDate = expedition.ExpeditionDate,
                ExpeditionHour = expedition.ExpeditionHour,
                ExpeditionPrice = expedition.ExpeditionPrice,
                IsActive = expedition.IsActive,
                IsFinish = expedition.IsFinish
            };
            ViewBag.Cities = new SelectList(_cityService.GetAll(), "CityName", "CityName");
            ViewBag.Buses = new SelectList(_busService.GetBusByActive(), "BusId", "BusPlaque");
            return View(model);
        }
        [HttpPost]
        public IActionResult ExpeditionEdit(ExpeditionModel expedition)
        {
            if (ModelState.IsValid)
            {
                Expedition model = new Expedition()
                {
                    ExpeditionId = expedition.ExpeditionId,
                    BusId = expedition.BusId,
                    ExpeditionStart = expedition.ExpeditionStart,
                    ExpeditionStation = expedition.ExpeditionStation,
                    ExpeditionFinish = expedition.ExpeditionFinish,
                    ExpeditionDate = expedition.ExpeditionDate,
                    ExpeditionHour = expedition.ExpeditionHour,
                    ExpeditionPrice = expedition.ExpeditionPrice,
                    IsActive = expedition.IsActive,
                    IsFinish = expedition.IsFinish
                };
                _expeditionService.Update(model);
                return RedirectToAction("ExpeditionList");
            }
            ViewBag.Cities = new SelectList(_cityService.GetAll(), "CityName", "CityName");
            ViewBag.Buses = new SelectList(_busService.GetBusByActive(), "BusId", "BusPlaque");
            return View(expedition);

        }
        public IActionResult ExpeditionDelete(int id)
        {
            _expeditionService.ExpeditionDelete(id);
            _expeditionService.ExpeditionFinish(id);
            _busService.BusExpeditionFinish(_expeditionService.GetBusIdByExpeditionId(id));
            return RedirectToAction("ExpeditionList");
        }
        public IActionResult ExpeditionFinish(int id)
        {
            _expeditionService.ExpeditionFinish(id);
            _busService.BusExpeditionFinish(_expeditionService.GetBusIdByExpeditionId(id));
            return RedirectToAction("ExpeditionList");
        }
        public IActionResult ExpeditionDeletedList()
        {
            return View(_expeditionService.GetExpeditionByDeleted());
        }
        public IActionResult ExpeditionFinishedList()
        {
            return View(_expeditionService.GetExpeditionByFinished());
        }
        //Expedition Action Finish


    }
}
