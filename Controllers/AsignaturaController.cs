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
        [Route("Asignatura/Index/")]
       [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asig = _context.asignaturas.Where(p => p.Id == asignaturaId);
                return View(asig.SingleOrDefault());

            }
            else { 
            return View("MultiAsignatura", _context.asignaturas);

            }
        
        }
        public IActionResult MultiAsignatura() {


            return View("MultiAsignatura",_context.asignaturas);

        }
    }
}
