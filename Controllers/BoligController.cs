using Boligprospektet.Models.Models_Bolig;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Bolig;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class BoligController : Controller
    {
        private readonly IBoligRepository _boligRepository;

        public BoligController(IBoligRepository boligRepository)
        {
            _boligRepository = boligRepository;
        }

        [Route("{id?}")]
        //Return specific Bolig with Details
        public ViewResult Details(int? id)
        {
            Bolig bolig = _boligRepository.GetBolig(id.Value);
            if (bolig == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig/BoligNotFound.cshtml", id.Value);
            }

            BoligDetailsViewModel boligDetailsViewModel = new BoligDetailsViewModel()
            {
                //Bolig = _boligRepository.GetBolig(id ?? 1),
                Bolig = bolig,

                PageTitle = "Bolig Details"
            };
            return View("~/Views/Views_Bolig/Details.cshtml", boligDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Bolig/List")]
        //Return all Boligs
        public ViewResult List()
        {
            var model = _boligRepository.GetAllBoligs();
            return View("~/Views/Views_Bolig/List.cshtml", model);
        }

        [Route("/Bolig/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Bolig Register";
            return View("~/Views/Views_Bolig/Register.cshtml");
        }

    
        //Return Registered Bolig to db
        [HttpPost]
        public IActionResult Register(BoligCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig newBolig = new Bolig
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Type_Id = model.Type_Id,
                    Adresse_Vej = model.Adresse_Vej,
                    Adresse_Postnr = model.Adresse_Postnr,
                    Adresse_Code = model.Adresse_Code,
                    Adresse_By = model.Adresse_By,
                    Leje_kr = model.Leje_kr,
                    Deposit_kr = model.Deposit_kr,
                    Areal_msquare = model.Areal_msquare,
                    Antal_Værelser = model.Antal_Værelser,
                    Bolig_Beskrivelser = model.Bolig_Beskrivelser,
                    Bolig_Navn = model.Bolig_Navn,
                    Photos = model.Photos,
                    Ledig_Fra = model.Ledig_Fra,
                    Annonse_Til = model.Annonse_Til,
                };
                _boligRepository.Create(newBolig);
                return RedirectToAction("Details", new { id = newBolig.Bolig_Id });
            }
            return View("~/Views/Views_Bolig/Register.cshtml");

        }

        //Return Edit View
        [Route("/Bolig/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Bolig bolig = _boligRepository.GetBolig(id);
            if (bolig == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig/BoligNotFound.cshtml", id);
            }
            BoligEditViewModel boligEditViewModel = new BoligEditViewModel
            {
                Bolig_Id = bolig.Bolig_Id,
                Date_Time = bolig.Date_Time,
                User_Id = bolig.User_Id,
                Type_Id = bolig.Type_Id,
                Adresse_Vej = bolig.Adresse_Vej,
                Adresse_Postnr = bolig.Adresse_Postnr,
                Adresse_Code = bolig.Adresse_Code,
                Adresse_By = bolig.Adresse_By,
                Leje_kr = bolig.Leje_kr,
                Deposit_kr = bolig.Deposit_kr,
                Areal_msquare = bolig.Areal_msquare,
                Antal_Værelser = bolig.Antal_Værelser,
                Bolig_Beskrivelser = bolig.Bolig_Beskrivelser,
                Bolig_Navn = bolig.Bolig_Navn,
                Photos = bolig.Photos,
                Ledig_Fra = bolig.Ledig_Fra,
                Annonse_Til = bolig.Annonse_Til,
            };
            return View("~/Views/Views_Bolig/Edit.cshtml", boligEditViewModel);
        }

        //Return Edited Bolig to db
        [HttpPost]
        public IActionResult Edit(BoligEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig bolig = _boligRepository.GetBolig(model.Bolig_Id);

                bolig.Date_Time = model.Date_Time;
                bolig.User_Id = model.User_Id;
                bolig.Type_Id = model.Type_Id;
                bolig.Adresse_Vej = model.Adresse_Vej;
                bolig.Adresse_Postnr = model.Adresse_Postnr;
                bolig.Adresse_Code = model.Adresse_Code;
                bolig.Adresse_By = model.Adresse_By;
                bolig.Leje_kr = model.Leje_kr;
                bolig.Deposit_kr = model.Deposit_kr;
                bolig.Areal_msquare = model.Areal_msquare;
                bolig.Antal_Værelser = model.Antal_Værelser;
                bolig.Bolig_Beskrivelser = model.Bolig_Beskrivelser;
                bolig.Bolig_Navn = model.Bolig_Navn;
                bolig.Photos = model.Photos;
                bolig.Ledig_Fra = model.Ledig_Fra;
                bolig.Annonse_Til = model.Annonse_Til;

                _boligRepository.Update(bolig);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Bolig/Edit.cshtml");
        }

        
        //Delete that particular bolig
        public IActionResult Delete(int id)
        {
            Bolig bolig = _boligRepository.GetBolig(id);
            if (bolig == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig/BoligNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _boligRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
