using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Classes;
using LibraryProject.Data;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Controllers
{
    public class BookController : Controller
    {
        private DataContext _context;

        public BookController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ShowBook()
        {
            MultipleViewModel user = new MultipleViewModel();
            user.user = HttpContext.Session.GetObjectFromJson<User>("userInfos");
            user.book = HttpContext.Session.GetObjectFromJson<Book>("oneBook");
            user.author = HttpContext.Session.GetObjectFromJson<Author>("oneAuthor");
            user.library = HttpContext.Session.GetObjectFromJson<Library>("oneLibrary");

            if (user.user != null)
            {
                MultipleViewModel u1 = new MultipleViewModel();
                u1.user.id = Convert.ToInt32(user.user.id);
                u1.user.name = user.user.name.ToString();
                u1.user.surname = user.user.surname.ToString();
                u1.user.email = user.user.email.ToString();
                u1.user.nick = user.user.nick.ToString();
                u1.user.password = user.user.password.ToString();

                u1.book.id = user.book.id;
                u1.book.name = user.book.name;
                u1.book.description = user.book.description;
                u1.book.imageURL = user.book.imageURL;
                u1.book.categoryName = user.book.categoryName;

                u1.author.id = user.author.id;
                u1.author.name = user.author.name;
                u1.author.surname = user.author.surname;

                u1.library.id = user.library.id;
                u1.library.name = user.library.name;
                u1.library.address = user.library.address;
                u1.library.tel = user.library.tel;
                u1.library.email = user.library.email;

                return View(u1);
            }
            else
            {
                MultipleViewModel u2 = new MultipleViewModel();
                u2.user.id = 0;
                u2.user.name = " Login";

                u2.book.id = user.book.id;
                u2.book.name = user.book.name;
                u2.book.description = user.book.description;
                u2.book.imageURL = user.book.imageURL;
                u2.book.categoryName = user.book.categoryName;

                u2.author.id = user.author.id;
                u2.author.name = user.author.name;
                u2.author.surname = user.author.surname;

                u2.library.id = user.library.id;
                u2.library.name = user.library.name;
                u2.library.address = user.library.address;
                u2.library.tel = user.library.tel;
                u2.library.email = user.library.email;

                return View(u2);
            }
        }

        [HttpGet]
        public IActionResult ShowBooks()
        {
            MultipleViewModel user = new MultipleViewModel();
            user.user = HttpContext.Session.GetObjectFromJson<User>("userInfos");

            user.Books = HttpContext.Session.GetList("moreBook");

            user.author = HttpContext.Session.GetObjectFromJson<Author>("moreAuthor");

            if (user.user != null)
            {
                MultipleViewModel u1 = new MultipleViewModel();
                u1.user.id = Convert.ToInt32(user.user.id);
                u1.user.name = user.user.name.ToString();
                u1.user.surname = user.user.surname.ToString();
                u1.user.email = user.user.email.ToString();
                u1.user.nick = user.user.nick.ToString();
                u1.user.password = user.user.password.ToString();

                u1.Books = user.Books;

                u1.author.id = user.author.id;
                u1.author.name = user.author.name;
                u1.author.surname = user.author.surname;

                return View(u1);
            }
            else
            {
                MultipleViewModel u2 = new MultipleViewModel();
                u2.user.id = 0;
                u2.user.name = " Login";

                u2.Books = user.Books;

                u2.author.id = user.author.id;
                u2.author.name = user.author.name;
                u2.author.surname = user.author.surname;

                return View(u2);
            }
        }

        [HttpPost]
        public IActionResult SearchBook()
        {
            string typeValue = Request.Form["type"].ToString();
            string inputValue = Request.Form["input"].ToString();

            var isMatch=_context.Books.FirstOrDefault(x => x.name == inputValue);

            if (typeValue == "title" && isMatch!=null )
            {
                using (_context)
                {
                    var book = (from i in _context.Books
                                where (i.name == inputValue)
                                select new
                                {
                                    i.id,
                                    i.name,
                                    i.description,
                                    i.imageURL,
                                    i.categoryName,
                                    i.authorID,
                                    i.libraryID
                                }).FirstOrDefault();

                    var author = (from i in _context.Authors
                                  where (i.id == book.authorID)
                                  select new
                                  {
                                      i.id,
                                      i.name,
                                      i.surname
                                  }
                        ).FirstOrDefault();

                    var library = (from i in _context.Libraries
                                  where (i.id == book.libraryID)
                                  select new
                                  {
                                      i.id,
                                      i.name,
                                      i.address,
                                      i.tel,
                                      i.email
                                  }
                        ).FirstOrDefault();

                    if (book != null||author!=null||library!=null)
                    {
                        // frontend kısmı
                        HttpContext.Session.SetObjectAsJson("oneBook", book);
                        HttpContext.Session.SetObjectAsJson("oneAuthor", author);
                        HttpContext.Session.SetObjectAsJson("oneLibrary", library);

                        return RedirectToAction("ShowBook", "Book");
                    }
                    else
                    {
                        return RedirectToAction("Main", "Home");
                    }
                }
            }
            else if (typeValue == "author")
            {
                using (_context)
                {
                    var author = (from i in _context.Authors
                                where (i.name + " " + i.surname == inputValue)
                                select new
                                {
                                    i.Books,
                                    i.id,
                                    i.name,
                                    i.surname
                                }).FirstOrDefault();

                    if (author != null)
                    {
                        //frontend kısmı
                        HttpContext.Session.SetObjectAsJson("moreAuthor",author);
                        HttpContext.Session.SetList(author.Books,"moreBook");
                        return RedirectToAction("ShowBooks", "Book");
                    }
                    else
                    {
                        TempData["message"] = "Author Not Found";
                        return RedirectToAction("Main", "Home");
                    }
                }
            }
            else
            {
                TempData["message"] = "Title Not Found";
                return RedirectToAction("Main", "Home");
            }
        }

        public IActionResult EBook()
        {
            MultipleViewModel user = new MultipleViewModel();
            user.user = HttpContext.Session.GetObjectFromJson<User>("userInfos");
            user.isbn = HttpContext.Session.GetObjectFromJson<string>("isbnKey");
            if (user.user != null)
            {
                MultipleViewModel u1 = new MultipleViewModel();
                u1.user.id = Convert.ToInt32(user.user.id);
                u1.user.name = user.user.name.ToString();
                u1.user.surname = user.user.surname.ToString();
                u1.user.email = user.user.email.ToString();
                u1.user.nick = user.user.nick.ToString();
                u1.user.password = user.user.password.ToString();

                u1.isbn = user.isbn;

                return View(u1);
            }
            else
            {
                MultipleViewModel u2 = new MultipleViewModel();
                u2.user.id = 0;
                u2.user.name = " Login";

                u2.isbn = user.isbn;

                return View(u2);
            }
        }

        [HttpPost]
        public IActionResult SendIsbnNo()
        {
            string isbnNo = Request.Form["isbnno"].ToString();

            HttpContext.Session.SetObjectAsJson("isbnKey", isbnNo);

            return RedirectToAction("EBook", "Book");
        }
    }
}