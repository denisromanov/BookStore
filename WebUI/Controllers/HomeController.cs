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
<<<<<<< HEAD
        private int test = 2;
=======
        private int Tets = 2;
>>>>>>> testing
        private IBookRepository<Book> db;

        public HomeController()
        {
<<<<<<< HEAD
            test++;
=======
            Tets++;
>>>>>>> testing
            db = new BookRepository();

        }

        public ActionResult Index()
        {
<<<<<<< HEAD
            test ++;
=======
            
>>>>>>> testing
            return View();
        }

    }
}
