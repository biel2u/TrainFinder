using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainFinder.Domain.Abstract;
using TrainFinder.Domain.Entities;
using ActionParameterAlias;

namespace TrainFinder.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ITrainRepository repository;

        public HomeController(ITrainRepository repo)
        {
            this.repository = repo;
        }
        
        public ViewResult Index()
        {
            return View(); 
        }

        [ParameterAlias("trainNumber", "id")]
        public ActionResult FindTrain(int? trainNumber)
        {
            if (trainNumber != null)
            {
                var train = repository.Trains.Where(x => x.Number == trainNumber);
                if (!train.Any())
                {
                    TempData["message"] = string.Format("Nie znaleziono {0}", trainNumber);
                    return View("Index");
                }
                return View(train);
            }
            else
            {
                TempData["message"] = string.Format("Niepoprawny numer pociągu");
                return View("Index");
                
            }
        }
    }
}