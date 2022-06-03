using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Entity;
using CeylanTurizm.WebUI.Identity;
using CeylanTurizm.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IBusService _busService;
        private ICityService _cityService;
        private IExpeditionService _expeditionService;
        private ITicketSalesService _ticketSalesService;
        private UserManager<User> _userManager;

        public HomeController(IBusService busService, ICityService cityService, IExpeditionService expeditionService,
            ITicketSalesService ticketSalesService, UserManager<User> userManager)
        {
            _busService = busService;
            _cityService = cityService;
            _expeditionService = expeditionService;
            _ticketSalesService = ticketSalesService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PublicInformation()
        {
            return View();
        }
        public IActionResult KVKK()
        {
            return View();
        }
        public IActionResult PassengerRights()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult City(string name)
        {
            var cityListModel = new CityListViewModel()
            {
                CitiesAll = _cityService.GetAll(),
                CitiesByCityName = _cityService.GetCityByCityName(name)
            };
            return View(cityListModel);

        }
        public async Task<IActionResult> Expedition(CityListViewModel cityListViewModel)
        {
            string cityStart = cityListViewModel.Sales.cityStart;
            string cityFinish = cityListViewModel.Sales.cityFinish;
            string date = cityListViewModel.Sales.date;
            var expeditionandTicketSalesViewModel = new ExpeditionandTicketSalesViewModel();
            expeditionandTicketSalesViewModel.expeditions = _expeditionService
                .GetExpeditionsByExpeditionFinish(cityStart, cityFinish, date);
            expeditionandTicketSalesViewModel.User = await _userManager.GetUserAsync(User);
            foreach (var item in expeditionandTicketSalesViewModel.expeditions)
            {
                if (item.ExpeditionStation == cityStart || item.ExpeditionStation == cityFinish)
                {
                    item.ExpeditionPrice = item.ExpeditionPrice / 2;
                }
            }
            if (expeditionandTicketSalesViewModel.expeditions.Count() == 0)
            {
                ViewBag.Result = 0;
            }
            else
            {
                ViewBag.Result = 1;
            }
            expeditionandTicketSalesViewModel.ticketSales = _ticketSalesService.GetAll();
            return View(expeditionandTicketSalesViewModel);
        }

        [HttpPost]
        public IActionResult TicketSales(TicketSales sales)
        {
            _ticketSalesService.TicketSale(sales);
            var ticket = _ticketSalesService.GetTicketSalesById(sales.TicketSalesId);
            return View(ticket);
        }
        public IActionResult TicketQuery()
        {
            return View();
        }
        public IActionResult TicketFound(TicketSales ticketSales)
        {
            var ticketFound = _ticketSalesService.TicketFound(ticketSales.TicketSalesId, ticketSales.customerTcNo);
            if (ticketFound != null)
            {
                ViewBag.Control = 1;
            }
            else
            {
                ViewBag.Control = 0;
            }

            return View(ticketFound);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
