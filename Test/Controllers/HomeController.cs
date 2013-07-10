using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var models = SetUpCompanies();

            return View(models);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<Company> SetUpCompanies()
        {
            var companies = new List<Company>
                                {
                                    new Company(1, "Challenger", 899),
                                    new Company(2, "Westpac", 99),
                                    new Company(3, "CBA", 6152),
                                    new Company(4, "NAB", 9876),
                                    new Company(5, "Google", 10231),
                                    new Company(6, "NineMsn", 876),
                                    new Company(7, "eBay", 298),
                                    new Company(8, "PayPal", 6748),
                                    new Company(9, "ANZ", 2416)
                                };

            return companies;
        }
    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }

        public Company(int id, string name, int numEmployees)
        {
            Id = id;
            Name = name;
            NumberOfEmployees = numEmployees;
        }

        public string IdAsWord
        {
            get {
                return Id.ToString();

                //this should actually return the word of the number.
                //For exampe if id=1, function should return "one",
                //if id=2, function should return "9"

                //code it yourself or copy & paste from somewhere.. up to you.
            }
        }
    }
}
