using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookDB;
using BookDB.Abstract;
using BookDB.Entities;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private int test = 2;
        private IBookRepository<Book> db;

        public HomeController()
        {
            test++;
            db = new BookRepository();

        }

        public ActionResult Index()
        {
            test ++;
            return View();
        }

    }
}
