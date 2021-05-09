using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            
                people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
                people.Add(new PersonModel { FirstName = "John", LastName = "Doe", Age = 55 });
                people.Add(new PersonModel { FirstName = "Brittney", LastName = "Spears", Age = 46 });
            
            return View(people);
        }
    }
}