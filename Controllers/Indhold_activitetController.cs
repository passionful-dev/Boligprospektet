using Boligprospektet.Models.Models_Indhold_activitet;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Indhold_activitet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class Indhold_activitetController : Controller
    {
        private readonly IIndhold_activitetRepository _indhold_activitetRepository;

        public Indhold_activitetController(IIndhold_activitetRepository indhold_activitetRepository)
        {
            _indhold_activitetRepository = indhold_activitetRepository;
        }

        [Route("{id?}")]
        //Return specific Indhold_activitet with Details
        public ViewResult Details(int? id)
        {
            Indhold_activitet indhold_activitet = _indhold_activitetRepository.GetIndhold_activitet(id.Value);
            if (indhold_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold_activitet/Indhold_activitetNotFound.cshtml", id.Value);
            }

            Indhold_activitetDetailsViewModel indhold_activitetDetailsViewModel = new Indhold_activitetDetailsViewModel()
            {
                //Indhold_activitet = _indhold_activitetRepository.GetIndhold_activitet(id ?? 1),
                Indhold_activitet = indhold_activitet,

                PageTitle = "Indhold_activitet Details"
            };
            return View("~/Views/Views_Indhold_activitet/Details.cshtml", indhold_activitetDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Indhold_activitet/List")]
        //Return all Indhold_activitets
        public ViewResult List()
        {
            var model = _indhold_activitetRepository.GetAllIndhold_activitets();
            return View("~/Views/Views_Indhold_activitet/List.cshtml", model);
        }

        [Route("/Indhold_activitet/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Indhold_activitet Register";
            return View("~/Views/Views_Indhold_activitet/Register.cshtml");
        }

    
        //Return Registered Indhold_activitet to db
        [HttpPost]
        public IActionResult Register(Indhold_activitetCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Indhold_activitet newIndhold_activitet = new Indhold_activitet
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Indhold_Id = model.Indhold_Id,
                    Indhold_Navn = model.Indhold_Navn,
                    Indhold_activitet_Navn = model.Indhold_activitet_Navn,
                };
                _indhold_activitetRepository.Create(newIndhold_activitet);
                return RedirectToAction("Details", new { id = newIndhold_activitet.Indhold_activitet_Id });
            }
            return View("~/Views/Views_Indhold_activitet/Register.cshtml");

        }

        //Return Edit View
        [Route("/Indhold_activitet/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Indhold_activitet indhold_activitet = _indhold_activitetRepository.GetIndhold_activitet(id);
            if (indhold_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold_activitet/Indhold_activitetNotFound.cshtml", id);
            }
            Indhold_activitetEditViewModel indhold_activitetEditViewModel = new Indhold_activitetEditViewModel
            {
                Indhold_activitet_Id = indhold_activitet.Indhold_activitet_Id,
                Date_Time = indhold_activitet.Date_Time,
                User_Id = indhold_activitet.User_Id,
                Indhold_Id = indhold_activitet.Indhold_Id,
                Indhold_Navn = indhold_activitet.Indhold_Navn,
                Indhold_activitet_Navn = indhold_activitet.Indhold_activitet_Navn,
            };
            return View("~/Views/Views_Indhold_activitet/Edit.cshtml", indhold_activitetEditViewModel);
        }

        //Return Edited Indhold_activitet to db
        [HttpPost]
        public IActionResult Edit(Indhold_activitetEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Indhold_activitet indhold_activitet = _indhold_activitetRepository.GetIndhold_activitet(model.Indhold_activitet_Id);

                indhold_activitet.Date_Time = model.Date_Time;
                indhold_activitet.User_Id = model.User_Id;
                indhold_activitet.Indhold_Id = model.Indhold_Id;
                indhold_activitet.Indhold_Navn = model.Indhold_Navn;
                indhold_activitet.Indhold_activitet_Navn = model.Indhold_activitet_Navn;

                _indhold_activitetRepository.Update(indhold_activitet);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Indhold_activitet/Edit.cshtml");
        }

        
        //Delete that particular indhold_activitet
        public IActionResult Delete(int id)
        {
            Indhold_activitet indhold_activitet = _indhold_activitetRepository.GetIndhold_activitet(id);
            if (indhold_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold_activitet/Indhold_activitetNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _indhold_activitetRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
