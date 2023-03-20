using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext context;
        public IActionResult Index()
        {

            Escuela escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Roberto Muller";
            escuela.Pais = "Argentina";
            escuela.Ciudad = "Resistencia";
            escuela.Direccion = "Misionero Klein 440";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            return View(escuela);
        }

        public EscuelaController(EscuelaContext escuelaContext)
        {

            {
                context = escuelaContext;

            }




        }
    }
}
