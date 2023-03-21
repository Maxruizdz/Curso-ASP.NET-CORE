using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {

            var escuela = _context.escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext escuelaContext)
        {

            {
                _context = escuelaContext;

            }




        }
    }
}
