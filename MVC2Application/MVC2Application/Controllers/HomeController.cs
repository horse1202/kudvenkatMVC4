using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2Application.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public string Index()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
