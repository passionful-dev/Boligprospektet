using Boligprospektet.Models.Models_Bolig_type;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_Bolig_type;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class Bolig_typeController : Controller
    {
        private readonly IBolig_typeRepository _bolig_typeRepository;

        public Bolig_typeController(IBolig_typeRepository bolig_typeRepository)
        {
            _bolig_typeRepository = bolig_typeRepository;
        }

        [Route("{id?}")]
        //Return specific Bolig_type with Details
        public ViewResult Details(int? id)
        {
            Bolig_type bolig_type = _bolig_typeRepository.GetBolig_type(id.Value);
            if (bolig_type == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type/Bolig_typeNotFound.cshtml", id.Value);
            }

            Bolig_typeDetailsViewModel bolig_typeDetailsViewModel = new Bolig_typeDetailsViewModel()
            {
                //Bolig_type = _bolig_typeRepository.GetBolig_type(id ?? 1),
                Bolig_type = bolig_type,

                PageTitle = "Bolig_type Details"
            };
            return View("~/Views/Views_Bolig_type/Details.cshtml", bolig_typeDetailsViewModel);
        }

        //[Route("/")]
        [Route("/Bolig_type/List")]
        //Return all Bolig_types
        public ViewResult List()
        {
            var model = _bolig_typeRepository.GetAllBolig_types();
            return View("~/Views/Views_Bolig_type/List.cshtml", model);
        }

        [Route("/Bolig_type/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "Bolig_type Register";
            return View("~/Views/Views_Bolig_type/Register.cshtml");
        }

    
        //Return Registered Bolig_type to db
        [HttpPost]
        public IActionResult Register(Bolig_typeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_type newBolig_type = new Bolig_type
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Bolig_type_Navn = model.Bolig_type_Navn,
                };
                _bolig_typeRepository.Create(newBolig_type);
                return RedirectToAction("Details", new { id = newBolig_type.Bolig_type_Id });
            }
            return View("~/Views/Views_Bolig_type/Register.cshtml");

        }

        //Return Edit View
        [Route("/Bolig_type/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Bolig_type bolig_type = _bolig_typeRepository.GetBolig_type(id);
            if (bolig_type == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type/Bolig_typeNotFound.cshtml", id);
            }
            Bolig_typeEditViewModel bolig_typeEditViewModel = new Bolig_typeEditViewModel
            {
                Bolig_type_Id = bolig_type.Bolig_type_Id,
                Date_Time = bolig_type.Date_Time,
                User_Id = bolig_type.User_Id,
                Bolig_type_Navn = bolig_type.Bolig_type_Navn,
            };
            return View("~/Views/Views_Bolig_type/Edit.cshtml", bolig_typeEditViewModel);
        }

        //Return Edited Bolig_type to db
        [HttpPost]
        public IActionResult Edit(Bolig_typeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Bolig_type bolig_type = _bolig_typeRepository.GetBolig_type(model.Bolig_type_Id);

                bolig_type.Date_Time = model.Date_Time;
                bolig_type.User_Id = model.User_Id;
                bolig_type.Bolig_type_Navn = model.Bolig_type_Navn;

                _bolig_typeRepository.Update(bolig_type);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_Bolig_type/Edit.cshtml");
        }

        
        //Delete that particular bolig_type
        public IActionResult Delete(int id)
        {
            Bolig_type bolig_type = _bolig_typeRepository.GetBolig_type(id);
            if (bolig_type == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_Bolig_type/Bolig_typeNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _bolig_typeRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
