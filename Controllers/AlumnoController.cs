using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AlumnoController: Controller
    {
        EscuelaContext _context;
        public AlumnoController(EscuelaContext context) {
        
        _context=context;
        
        
        }
        public IActionResult Index()
        {
            return View(_context.alumnos.FirstOrDefault());
        }

        public IActionResult MultiALumno() {

        
            return View("MultiAlumno",_context.alumnos);

        }

    }
}
