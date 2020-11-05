using Boligprospektet.Models.Models_Facilitet;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Facilitet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class FacilitetController : Controller
    {
        private readonly IFacilitetRepository _facilitetRepository;

        public FacilitetController(IFacilitetRepository facilitetRepository)
        {
            _facilitetRepository = facilitetRepository;
        }

        [Route("{id?}")]
        //Return specific Facilitet with Details
        public ViewResult Details(int? id)
        {
            Facilitet facilitet = _facilitetRepository.GetFacilitet(id.Value);
            if (facilitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Facilitet/FacilitetNotFound.cshtml", id.Value);
            }

            FacilitetDetailsViewModel facilitetDetailsViewModel = new FacilitetDetailsViewModel()
            {
                //Facilitet = _facilitetRepository.GetFacilitet(id ?? 1),
                Facilitet = facilitet,

                PageTitle = "Facilitet Details"
            };
            return View("~/Views/Views_Facilitet/Details.cshtml", facilitetDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Facilitet/List")]
        //Return all Facilitets
        public ViewResult List()
        {
            var model = _facilitetRepository.GetAllFacilitets();
            return View("~/Views/Views_Facilitet/List.cshtml", model);
        }

        [Route("/Facilitet/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Facilitet Register";
            return View("~/Views/Views_Facilitet/Register.cshtml");
        }

    
        //Return Registered Facilitet to db
        [HttpPost]
        public IActionResult Register(FacilitetCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Facilitet newFacilitet = new Facilitet
                {
                    Bolig_Id = model.Bolig_Id,
                    Faciliteter = model.Faciliteter,
                    Facilitet_Beskrivelser = model.Facilitet_Beskrivelser,
                };
                _facilitetRepository.Create(newFacilitet);
                return RedirectToAction("Details", new { id = newFacilitet.Facilitet_Id });
            }
            return View("~/Views/Views_Facilitet/Register.cshtml");

        }

        //Return Edit View
        [Route("/Facilitet/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Facilitet facilitet = _facilitetRepository.GetFacilitet(id);
            if (facilitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Facilitet/FacilitetNotFound.cshtml", id);
            }
            FacilitetEditViewModel facilitetEditViewModel = new FacilitetEditViewModel
            {
                Facilitet_Id = facilitet.Facilitet_Id,
                Bolig_Id = facilitet.Bolig_Id,
                Faciliteter = facilitet.Faciliteter,
                Facilitet_Beskrivelser = facilitet.Facilitet_Beskrivelser,
            };
            return View("~/Views/Views_Facilitet/Edit.cshtml", facilitetEditViewModel);
        }

        //Return Edited Facilitet to db
        [HttpPost]
        public IActionResult Edit(FacilitetEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Facilitet facilitet = _facilitetRepository.GetFacilitet(model.Facilitet_Id);

                facilitet.Bolig_Id = model.Bolig_Id;
                facilitet.Faciliteter = model.Faciliteter;
                facilitet.Facilitet_Beskrivelser = model.Facilitet_Beskrivelser;

                _facilitetRepository.Update(facilitet);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Facilitet/Edit.cshtml");
        }

        
        //Delete that particular facilitet
        public IActionResult Delete(int id)
        {
            Facilitet facilitet = _facilitetRepository.GetFacilitet(id);
            if (facilitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Facilitet/FacilitetNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _facilitetRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
