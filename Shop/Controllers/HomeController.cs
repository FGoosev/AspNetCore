using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Interfaces;
using Lab8_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab8_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;


        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
