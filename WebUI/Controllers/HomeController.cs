using System;
using System.Collections.Generic;
using System.EnterpriseServices;
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

        private IBookRepository<Book> db;

        public HomeController()
        {
            db = new BookRepository();
        }

        public ActionResult Index()
        {
            
            return View();
        }

    }
}
