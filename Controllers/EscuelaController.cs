using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index() {

            Escuela escuela = new Escuela() ;
            escuela.AñodeFundacion = 2005;
            escuela.EscuelaID = Guid.NewGuid().ToString();
            escuela.Nombre = "Roberto Muller";

            return View(escuela);
        }


    }
}
