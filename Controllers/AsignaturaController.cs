using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index() {
            Asignatura asignatura = new Asignatura();
            asignatura.Nombre = "Biologia";


            return View(asignatura);

        }
    }
}
