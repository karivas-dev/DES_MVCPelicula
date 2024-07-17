using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string nombre, string apellido, int numVeces)
        {
            ViewData["numVeces"] = numVeces;
            ViewData["nombre"] = nombre;
            ViewData["apellido"] = apellido;

            return View();
        }
    }
}
