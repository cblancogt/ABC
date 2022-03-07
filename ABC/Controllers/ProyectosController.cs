using ABC.Data;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.Controllers
{
    public class ProyectosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProyectosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Proyecto> listaProyectos = _context.Proyecto;
            return View(listaProyectos);
        }

        public IActionResult CrearProyecto()
        {
            return View();    
        }

        [HttpPost]
        public IActionResult CrearProyecto(Proyecto proyecto)
        {
            if (ModelState.IsValid)
            {
                _context.Proyecto.Add(proyecto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
           
    }
}
