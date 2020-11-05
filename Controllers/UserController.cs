using Boligprospektet.Models.Models_User;
using Boligprospektet.ViewModels;
using Boligprospektet.ViewModels.ViewModels_User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("{id?}")]
        //Return specific User with Details
        public ViewResult Details(int? id)
        {
            User user = _userRepository.GetUser(id.Value);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User/UserNotFound.cshtml", id.Value);
            }

            UserDetailsViewModel userDetailsViewModel = new UserDetailsViewModel()
            {
                //User = _userRepository.GetUser(id ?? 1),
                User = user,

                PageTitle = "User Details"
            };
            return View("~/Views/Views_User/Details.cshtml", userDetailsViewModel);
        }

        [Route("/")]
        //[Route("/")]
        [Route("/User/List")]
        //Return all Users
        public ViewResult List()
        {
            var model = _userRepository.GetAllUsers();
            return View("~/Views/Views_User/List.cshtml", model);
        }

        [Route("/User/Register")]
        //Return Register View
        [HttpGet]
        public ViewResult Register()
        {
            ViewBag.PageTitle = "User Register";
            return View("~/Views/Views_User/Register.cshtml");
        }

    
        //Return Registered User to db
        [HttpPost]
        public IActionResult Register(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Date_Time = model.Date_Time,
                    Fuldnavn = model.Fuldnavn,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.Mobile,
                    User_Type = model.User_Type,
                };
                _userRepository.Create(newUser);
                return RedirectToAction("Details", new { id = newUser.User_Id });
            }
            return View("~/Views/Views_User/Register.cshtml");

        }

        //Return Edit View
        [Route("/User/Edit")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            User user = _userRepository.GetUser(id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User/UserNotFound.cshtml", id);
            }
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                User_Id = user.User_Id,
                Date_Time = user.Date_Time,
                Fuldnavn = user.Fuldnavn,
                Email = user.Email,
                Password = user.Password,
                Mobile = user.Mobile,
                User_Type = user.User_Type,
            };
            return View("~/Views/Views_User/Edit.cshtml", userEditViewModel);
        }

        //Return Edited User to db
        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userRepository.GetUser(model.User_Id);

                user.Date_Time = model.Date_Time;
                user.Fuldnavn = model.Fuldnavn;
                user.Email = model.Email;
                user.Password = model.Password;
                user.Mobile = model.Mobile;
                user.User_Type = model.User_Type;

                _userRepository.Update(user);
                return RedirectToAction("List");
            }
            return View("~/Views/Views_User/Edit.cshtml");
        }

        
        //Delete that particular user
        public IActionResult Delete(int id)
        {
            User user = _userRepository.GetUser(id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("~/Views/Views_User/UserNotFound.cshtml", id);
            }

            if (ModelState.IsValid)
            {
                _userRepository.Delete(id);
            }
            return RedirectToAction("List");
        }

    }

}
