using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Classes;
using LibraryProject.Data;
using LibraryProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            MultipleViewModel user = new MultipleViewModel();
            user.user= HttpContext.Session.GetObjectFromJson<User>("userInfos");

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
                u2.user.id = 0;
                u2.user.name = " Login";
                return View(u2);
            }
        }

        public IActionResult AboutUs()
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
                u2.user.id = 0;
                u2.user.name = " Login";
                return View(u2);
            }
        }
    }
}
