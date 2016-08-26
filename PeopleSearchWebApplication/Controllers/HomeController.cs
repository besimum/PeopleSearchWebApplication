using PeopleSearchWebApplication.DAL;
using PeopleSearchWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleSearchWebApplication.Controllers
{
    public class HomeController : Controller
    {
        //People_dbEntities1 _db;
        private PeopleContext db = new PeopleContext();

        /*public HomeController()
        {
            _db = new People_dbEntities1();
        }*/

        /*public ActionResult Index()
        {
            return View();
        }*/

        public PartialViewResult SearchPeople(string keyword)
        {
            System.Threading.Thread.Sleep(2500);
            var data = db.Person.Where(f => f.FirstName.ToUpper().Contains(keyword.ToUpper())
            || f.LastName.ToUpper().Contains(keyword.ToUpper()));
            return PartialView(data.ToList());
        }

        public ActionResult Index(string searchName)
        {
             var persons = from p in db.Person
                          select p;

             if (!String.IsNullOrEmpty(searchName))
            {
                //persons = persons.Where(str => str.FirstName.Contains(searchName));
                persons = persons.Where(p => p.FirstName.ToUpper().Contains(searchName.ToUpper())
                ||
                p.LastName.ToUpper().Contains(searchName.ToUpper()));
            }

            return View(persons.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "The People Search Application";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View("Contact");
        }

        public ActionResult Person()
        {
            ViewBag.Message = "People Search Page.";

            return View(db.Person.ToList());
        }

        // Added Create Method Aug 23
        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Salutation,FirstName,MiddleInitial,LastName,JobTitle")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

    }
}