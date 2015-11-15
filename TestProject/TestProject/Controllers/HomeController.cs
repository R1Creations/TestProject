using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your A SP.NET MVC application.";

            for (int i = 0; i < 11; i++)
            {
                var test = Number();
                var test1 = test.Aggregate((x, y) => x + y);
            }

            return View();
        }

        private IEnumerable<int> Number()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
            var test= "Aroan";
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
    }
}
