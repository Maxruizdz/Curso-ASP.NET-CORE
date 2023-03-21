using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using System.Linq;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController: Controller
    {
        EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {

            _context = context;


        }
        public IActionResult Index() {


            return View(_context.asignaturas.FirstOrDefault()
        );
        }   
        public IActionResult MultiAsignatura() {


            return View("MultiAsignatura",_context.asignaturas);

        }
    }
}
