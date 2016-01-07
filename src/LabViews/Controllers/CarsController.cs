using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LabViews.ViewModels;
using LabViews.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LabViews.Controllers
{
    public class CarsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(ListCarViewModel cars)
        {
            if (!ModelState.IsValid)
                return View();
            DataManager.ListCars(cars);
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCarViewModel car)
        {
            if (!ModelState.IsValid)
                return View();
            else if (car.AcceptTerms == false)
                return View();
            DataManager.AddCar(car);
            return RedirectToAction("index");
        }
    }
}
