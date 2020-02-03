using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Data;
using LibraryProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using LibraryProject.Classes;

namespace LibraryProject.Controllers
{
    public class UserController : Controller
    {
        private DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            var user = HttpContext.Session.GetObjectFromJson<User>("userInfos");

            if (ModelState.IsValid && user!=null)
            {
                TempData["message"] = "Message Sent Successfully";
                _context.Contacts.Add(contact);
                _context.SaveChanges();
            }
            else
            {
                TempData["message"] = "Please Login First";
                return RedirectToAction("Main", "Home");
            }
            return RedirectToAction("Main", "Home");
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var userInfos = _context.Users.SingleOrDefault(x => x.nick == user.nick && x.password == user.password);
                if (userInfos == null)
                {
                    TempData["message"] = "Please Try Again";
                    return RedirectToAction("Main","Home");
                }
                else
                {
                    TempData["message"] = "Login Successfully";
                    HttpContext.Session.SetObjectAsJson("userInfos", userInfos);
                    return RedirectToAction("Main", "Home");
                }
            }
            else
            {
                return RedirectToAction("Main", "Home");
            }
        }

        public IActionResult EditProfile()
        {
            MultipleViewModel user = new MultipleViewModel();
            user.user = HttpContext.Session.GetObjectFromJson<User>("userInfos");

            if (user.user != null)
            {
                MultipleViewModel u1 = new MultipleViewModel();
                u1.user.id = Convert.ToInt32(user.user.id);
                u1.user.name = user.user.name.ToString();
                u1.user.surname = user.user.surname.ToString();
                u1.user.email = user.user.email.ToString();
                u1.user.nick = user.user.nick.ToString();
                u1.user.password = user.user.password.ToString();

                return View(u1);
            }
            else
            {
                MultipleViewModel u2 = new MultipleViewModel();
                u2.user.name = " Login";
                return View(u2);
            }
        }

        [HttpPost]
        public IActionResult EditProfilePost(User newUser)
        {
            User currentUser = HttpContext.Session.GetObjectFromJson<User>("userInfos");

            User oldUser = _context.Users.FirstOrDefault(x => x.id == currentUser.id);

            oldUser.name = newUser.name;
            oldUser.surname = newUser.surname;
            oldUser.email = newUser.email;
            oldUser.nick = newUser.nick;
            oldUser.password = newUser.password;

            HttpContext.Session.SetObjectAsJson("userInfos",oldUser);
            _context.SaveChanges();

            return RedirectToAction("EditProfile","User");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["message"] = "Logout Successfully";
            return RedirectToAction("Main","Home");
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                TempData["message"] = "Registration Successfully";
            }
            else
            {
                TempData["message"] = "Registration Failed";
                return RedirectToAction("Main", "Home");
            }
            return RedirectToAction("Main", "Home");
        }
    }
}