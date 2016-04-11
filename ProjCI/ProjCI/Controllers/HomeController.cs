using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjCI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public int soma(int valor1, int valor2)
        {
            //pracatá
            return valor1 + valor2 + 1;
        }
    }
}