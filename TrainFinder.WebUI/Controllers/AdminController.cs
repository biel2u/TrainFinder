using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainFinder.Domain.Abstract;
using TrainFinder.Domain.Entities;

namespace TrainFinder.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ITrainRepository repository;
        public AdminController(ITrainRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Trains);
        }

        public ViewResult Edit(int trainID)
        {
            Train train = repository.Trains.FirstOrDefault(p => p.TrainID == trainID);
            return View(train);
        }

        [HttpPost]
        public ActionResult Save(Train train)
        {
            if(ModelState.IsValid)
            {
                repository.SaveChanges(train);
                TempData["message"] = string.Format("Zapisano zmiany!");
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
        }
    }
}