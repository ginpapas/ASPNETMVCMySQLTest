using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MySQLTest.Models;
using MySQLTest.DAL;


namespace MySQLTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBooksRepository _respository;

        public HomeController() : this(new BooksRepository()) { }

        public HomeController(BooksRepository repository)

        {

            _respository = repository;

        }


        public ActionResult Index()

        {

            return View(_respository.FindBooks());

        }


        public ActionResult Create()

        {

            return View();

        }


        [HttpPost]

        public async Task<ActionResult> Create(Book book)

        {

            try

            {

                if (ModelState.IsValid)

                {

                    _respository.AddBook(book);

                    await _respository.SaveAsync();

                    return RedirectToAction("Index");

                }


                return View(book);

            }

            catch

            {

                return View(book);

            }

        }


        public ActionResult About()

        {

            ViewBag.Message = "Your application description page.";


            return View();

        }


        public ActionResult Contact()

        {

            ViewBag.Message = "Your contact page.";


            return View();

        }

    }
}