using Boligprospektet.Models.Models_User_activitet;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_User_activitet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class User_activitetController : Controller
    {
        private readonly IUser_activitetRepository _user_activitetRepository;

        public User_activitetController(IUser_activitetRepository user_activitetRepository)
        {
            _user_activitetRepository = user_activitetRepository;
        }

        [Route("{id?}")]
        //Return specific User_activitet with Details
        public ViewResult Details(int? id)
        {
            User_activitet user_activitet = _user_activitetRepository.GetUser_activitet(id.Value);
            if (user_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User_activitet/User_activitetNotFound.cshtml", id.Value);
            }

            User_activitetDetailsViewModel user_activitetDetailsViewModel = new User_activitetDetailsViewModel()
            {
                //User_activitet = _user_activitetRepository.GetUser_activitet(id ?? 1),
                User_activitet = user_activitet,

                PageTitle = "User_activitet Details"
            };
            return View("~/Views/Views_User_activitet/Details.cshtml", user_activitetDetailsViewModel);
        }

        //[Route("/")]
        [Route("/User_activitet/List")]
        //Return all User_activitets
        public ViewResult List()
        {
            var model = _user_activitetRepository.GetAllUser_activitets();
            return View("~/Views/Views_User_activitet/List.cshtml", model);
        }

        [Route("/User_activitet/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "User_activitet Register";
            return View("~/Views/Views_User_activitet/Register.cshtml");
        }

    
        //Return Registered User_activitet to db
        [HttpPost]
        public IActionResult Register(User_activitetCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User_activitet newUser_activitet = new User_activitet
                {
                    Date_Time = model.Date_Time,
                    User_Id = model.User_Id,
                    Fuldnavn = model.Fuldnavn,
                    User_activitet_Navn = model.User_activitet_Navn,
                };
                _user_activitetRepository.Create(newUser_activitet);
                return RedirectToAction("Details", new { id = newUser_activitet.User_activitet_Id });
            }
            return View("~/Views/Views_User_activitet/Register.cshtml");

        }

        //Return Edit View
        [Route("/User_activitet/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            User_activitet user_activitet = _user_activitetRepository.GetUser_activitet(id);
            if (user_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User_activitet/User_activitetNotFound.cshtml", id);
            }
            User_activitetEditViewModel user_activitetEditViewModel = new User_activitetEditViewModel
            {
                User_activitet_Id = user_activitet.User_activitet_Id,
                Date_Time = user_activitet.Date_Time,
                User_Id = user_activitet.User_Id,
                Fuldnavn = user_activitet.Fuldnavn,
                User_activitet_Navn = user_activitet.User_activitet_Navn,
            };
            return View("~/Views/Views_User_activitet/Edit.cshtml", user_activitetEditViewModel);
        }

        //Return Edited User_activitet to db
        [HttpPost]
        public IActionResult Edit(User_activitetEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User_activitet user_activitet = _user_activitetRepository.GetUser_activitet(model.User_activitet_Id);

                user_activitet.Date_Time = model.Date_Time;
                user_activitet.User_Id = model.User_Id;
                user_activitet.Fuldnavn = model.Fuldnavn;
                user_activitet.User_activitet_Navn = model.User_activitet_Navn;

                _user_activitetRepository.Update(user_activitet);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_User_activitet/Edit.cshtml");
        }

        
        //Delete that particular user_activitet
        public IActionResult Delete(int id)
        {
            User_activitet user_activitet = _user_activitetRepository.GetUser_activitet(id);
            if (user_activitet == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User_activitet/User_activitetNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _user_activitetRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
