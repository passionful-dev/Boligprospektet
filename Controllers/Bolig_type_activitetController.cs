using Boligprospektet.Models.Models_Bolig_type_activitet;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Bolig_type_activitet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class Bolig_type_activitetController : Controller
    {
        private readonly IBolig_type_activitetRepository _bolig_type_activitetRepository;

        public Bolig_type_activitetController(IBolig_type_activitetRepository bolig_type_activitetRepository)
        {
            _bolig_type_activitetRepository = bolig_type_activitetRepository;
        }

        [Route("{id?}")]
        //Return specific Bolig_type_activitet with Details
        public ViewResult Details(int? id)
        {
            Bolig_type_activitet bolig_type_activitet = _bolig_type_activitetRepository.GetBolig_type_activitet(id.Value);
            if (bolig_type_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type_activitet/Bolig_type_activitetNotFound.cshtml", id.Value);
            }

            Bolig_type_activitetDetailsViewModel bolig_type_activitetDetailsViewModel = new Bolig_type_activitetDetailsViewModel()
            {
                //Bolig_type_activitet = _bolig_type_activitetRepository.GetBolig_type_activitet(id ?? 1),
                Bolig_type_activitet = bolig_type_activitet,

                PageTitle = "Bolig_type_activitet Details"
            };
            return View("~/Views/Views_Bolig_type_activitet/Details.cshtml", bolig_type_activitetDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Bolig_type_activitet/List")]
        //Return all Bolig_type_activitets
        public ViewResult List()
        {
            var model = _bolig_type_activitetRepository.GetAllBolig_type_activitets();
            return View("~/Views/Views_Bolig_type_activitet/List.cshtml", model);
        }

        [Route("/Bolig_type_activitet/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Bolig_type_activitet Register";
            return View("~/Views/Views_Bolig_type_activitet/Register.cshtml");
        }

    
        //Return Registered Bolig_type_activitet to db
        [HttpPost]
        public IActionResult Register(Bolig_type_activitetCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_type_activitet newBolig_type_activitet = new Bolig_type_activitet
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Bolig_type_Id = model.Bolig_type_Id,
                    Bolig_type_Navn = model.Bolig_type_Navn,
                    Bolig_type_activitet_Navn = model.Bolig_type_activitet_Navn,
                };
                _bolig_type_activitetRepository.Create(newBolig_type_activitet);
                return RedirectToAction("Details", new { id = newBolig_type_activitet.Bolig_type_activitet_Id });
            }
            return View("~/Views/Views_Bolig_type_activitet/Register.cshtml");

        }

        //Return Edit View
        [Route("/Bolig_type_activitet/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Bolig_type_activitet bolig_type_activitet = _bolig_type_activitetRepository.GetBolig_type_activitet(id);
            if (bolig_type_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type_activitet/Bolig_type_activitetNotFound.cshtml", id);
            }
            Bolig_type_activitetEditViewModel bolig_type_activitetEditViewModel = new Bolig_type_activitetEditViewModel
            {
                Bolig_type_activitet_Id = bolig_type_activitet.Bolig_type_activitet_Id,
                Date_Time = bolig_type_activitet.Date_Time,
                User_Id = bolig_type_activitet.User_Id,
                Bolig_type_Id = bolig_type_activitet.Bolig_type_Id,
                Bolig_type_Navn = bolig_type_activitet.Bolig_type_Navn,
                Bolig_type_activitet_Navn = bolig_type_activitet.Bolig_type_activitet_Navn,
            };
            return View("~/Views/Views_Bolig_type_activitet/Edit.cshtml", bolig_type_activitetEditViewModel);
        }

        //Return Edited Bolig_type_activitet to db
        [HttpPost]
        public IActionResult Edit(Bolig_type_activitetEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_type_activitet bolig_type_activitet = _bolig_type_activitetRepository.GetBolig_type_activitet(model.Bolig_type_activitet_Id);

                bolig_type_activitet.Date_Time = model.Date_Time;
                bolig_type_activitet.User_Id = model.User_Id;
                bolig_type_activitet.Bolig_type_Id = model.Bolig_type_Id;
                bolig_type_activitet.Bolig_type_Navn = model.Bolig_type_Navn;
                bolig_type_activitet.Bolig_type_activitet_Navn = model.Bolig_type_activitet_Navn;

                _bolig_type_activitetRepository.Update(bolig_type_activitet);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Bolig_type_activitet/Edit.cshtml");
        }

        
        //Delete that particular bolig_type_activitet
        public IActionResult Delete(int id)
        {
            Bolig_type_activitet bolig_type_activitet = _bolig_type_activitetRepository.GetBolig_type_activitet(id);
            if (bolig_type_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type_activitet/Bolig_type_activitetNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _bolig_type_activitetRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
