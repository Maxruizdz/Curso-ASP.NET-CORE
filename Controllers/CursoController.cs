﻿using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso = from cur in _context.cursos
                            where cur.Id == id
                            select cur;

                return View(curso.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.cursos);
            }
        }

        public IActionResult MultiCurso()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.cursos);
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }


        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var escuela = _context.escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;
                _context.cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExra = "Curso Creado";
                return View("Index", curso);
            }
            else
            {
                return View(curso);
            }

        }

    }
}
