using System.Web.Mvc;

namespace ProjCI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public int Soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int Subtrai(int valor1, int valor2)
        {
            return valor1 - valor2;
            //pracatá
        }

        public decimal Divide(int divisor, int dividendo)
        {
            return divisor / dividendo;
        }

        public int Multiplica(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
    }
}