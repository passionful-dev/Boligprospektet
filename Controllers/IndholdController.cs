using Boligprospektet.Models.Models_Indhold;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Indhold;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class IndholdController : Controller
    {
        private readonly IIndholdRepository _indholdRepository;

        public IndholdController(IIndholdRepository indholdRepository)
        {
            _indholdRepository = indholdRepository;
        }

        [Route("{id?}")]
        //Return specific Indhold with Details
        public ViewResult Details(int? id)
        {
            Indhold indhold = _indholdRepository.GetIndhold(id.Value);
            if (indhold == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold/IndholdNotFound.cshtml", id.Value);
            }

            IndholdDetailsViewModel indholdDetailsViewModel = new IndholdDetailsViewModel()
            {
                //Indhold = _indholdRepository.GetIndhold(id ?? 1),
                Indhold = indhold,

                PageTitle = "Indhold Details"
            };
            return View("~/Views/Views_Indhold/Details.cshtml", indholdDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Indhold/List")]
        //Return all Indholds
        public ViewResult List()
        {
            var model = _indholdRepository.GetAllIndholds();
            return View("~/Views/Views_Indhold/List.cshtml", model);
        }

        [Route("/Indhold/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Indhold Register";
            return View("~/Views/Views_Indhold/Register.cshtml");
        }

    
        //Return Registered Indhold to db
        [HttpPost]
        public IActionResult Register(IndholdCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Indhold newIndhold = new Indhold
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Indhold_Navn = model.Indhold_Navn,
                    Indhold_Beskrivelser = model.Indhold_Beskrivelser,
                };
                _indholdRepository.Create(newIndhold);
                return RedirectToAction("Details", new { id = newIndhold.Indhold_Id });
            }
            return View("~/Views/Views_Indhold/Register.cshtml");

        }

        //Return Edit View
        [Route("/Indhold/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Indhold indhold = _indholdRepository.GetIndhold(id);
            if (indhold == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold/IndholdNotFound.cshtml", id);
            }
            IndholdEditViewModel indholdEditViewModel = new IndholdEditViewModel
            {
                Indhold_Id = indhold.Indhold_Id,
                Date_Time = indhold.Date_Time,
                User_Id = indhold.User_Id,
                Indhold_Navn = indhold.Indhold_Navn,
                Indhold_Beskrivelser = indhold.Indhold_Beskrivelser,
            };
            return View("~/Views/Views_Indhold/Edit.cshtml", indholdEditViewModel);
        }

        //Return Edited Indhold to db
        [HttpPost]
        public IActionResult Edit(IndholdEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Indhold indhold = _indholdRepository.GetIndhold(model.Indhold_Id);

                indhold.Date_Time = model.Date_Time;
                indhold.User_Id = model.User_Id;
                indhold.Indhold_Navn = model.Indhold_Navn;
                indhold.Indhold_Beskrivelser = model.Indhold_Beskrivelser;

                _indholdRepository.Update(indhold);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Indhold/Edit.cshtml");
        }

        
        //Delete that particular indhold
        public IActionResult Delete(int id)
        {
            Indhold indhold = _indholdRepository.GetIndhold(id);
            if (indhold == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Indhold/IndholdNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _indholdRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
