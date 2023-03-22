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
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alumn in _context.alumnos
                             where alumn.Id == id
                             select alumn;

                return View(alumno.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.alumnos);
            }
        }

        public IActionResult MultiALumno() {

        
            return View("MultiAlumno",_context.alumnos);

        }

    }
}
