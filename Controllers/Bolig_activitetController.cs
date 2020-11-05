using Boligprospektet.Models.Models_Bolig_activitet;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Bolig_activitet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class Bolig_activitetController : Controller
    {
        private readonly IBolig_activitetRepository _bolig_activitetRepository;

        public Bolig_activitetController(IBolig_activitetRepository bolig_activitetRepository)
        {
            _bolig_activitetRepository = bolig_activitetRepository;
        }

        [Route("{id?}")]
        //Return specific Bolig_activitet with Details
        public ViewResult Details(int? id)
        {
            Bolig_activitet bolig_activitet = _bolig_activitetRepository.GetBolig_activitet(id.Value);
            if (bolig_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_activitet/Bolig_activitetNotFound.cshtml", id.Value);
            }

            Bolig_activitetDetailsViewModel bolig_activitetDetailsViewModel = new Bolig_activitetDetailsViewModel()
            {
                //Bolig_activitet = _bolig_activitetRepository.GetBolig_activitet(id ?? 1),
                Bolig_activitet = bolig_activitet,

                PageTitle = "Bolig_activitet Details"
            };
            return View("~/Views/Views_Bolig_activitet/Details.cshtml", bolig_activitetDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Bolig_activitet/List")]
        //Return all Bolig_activitets
        public ViewResult List()
        {
            var model = _bolig_activitetRepository.GetAllBolig_activitets();
            return View("~/Views/Views_Bolig_activitet/List.cshtml", model);
        }

        [Route("/Bolig_activitet/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Bolig_activitet Register";
            return View("~/Views/Views_Bolig_activitet/Register.cshtml");
        }

    
        //Return Registered Bolig_activitet to db
        [HttpPost]
        public IActionResult Register(Bolig_activitetCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_activitet newBolig_activitet = new Bolig_activitet
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Bolig_Id = model.Bolig_Id,
                    Bolig_Navn = model.Bolig_Navn,
                    Bolig_activitet_Navn = model.Bolig_activitet_Navn,
                };
                _bolig_activitetRepository.Create(newBolig_activitet);
                return RedirectToAction("Details", new { id = newBolig_activitet.Bolig_activitet_Id });
            }
            return View("~/Views/Views_Bolig_activitet/Register.cshtml");

        }

        //Return Edit View
        [Route("/Bolig_activitet/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Bolig_activitet bolig_activitet = _bolig_activitetRepository.GetBolig_activitet(id);
            if (bolig_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_activitet/Bolig_activitetNotFound.cshtml", id);
            }
            Bolig_activitetEditViewModel bolig_activitetEditViewModel = new Bolig_activitetEditViewModel
            {
                Bolig_activitet_Id = bolig_activitet.Bolig_activitet_Id,
                Date_Time = bolig_activitet.Date_Time,
                User_Id = bolig_activitet.User_Id,
                Bolig_Id = bolig_activitet.Bolig_Id,
                Bolig_Navn = bolig_activitet.Bolig_Navn,
                Bolig_activitet_Navn = bolig_activitet.Bolig_activitet_Navn,
            };
            return View("~/Views/Views_Bolig_activitet/Edit.cshtml", bolig_activitetEditViewModel);
        }

        //Return Edited Bolig_activitet to db
        [HttpPost]
        public IActionResult Edit(Bolig_activitetEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_activitet bolig_activitet = _bolig_activitetRepository.GetBolig_activitet(model.Bolig_activitet_Id);

                bolig_activitet.Date_Time = model.Date_Time;
                bolig_activitet.User_Id = model.User_Id;
                bolig_activitet.Bolig_Id = model.Bolig_Id;
                bolig_activitet.Bolig_Navn = model.Bolig_Navn;
                bolig_activitet.Bolig_activitet_Navn = model.Bolig_activitet_Navn;

                _bolig_activitetRepository.Update(bolig_activitet);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Bolig_activitet/Edit.cshtml");
        }

        
        //Delete that particular bolig_activitet
        public IActionResult Delete(int id)
        {
            Bolig_activitet bolig_activitet = _bolig_activitetRepository.GetBolig_activitet(id);
            if (bolig_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_activitet/Bolig_activitetNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _bolig_activitetRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
