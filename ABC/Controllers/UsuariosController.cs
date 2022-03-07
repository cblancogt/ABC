using ABC.Data;
using ABC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //crear una lista de libros
            IEnumerable<Usuario> listaUsuarios = _context.Usuario;


            return View(listaUsuarios);
        }

        [HttpGet]
        public IActionResult Login()
        {
           
            return View("Login");
        }

       [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            if(ModelState.IsValid){
                var validar = _context.Usuario.Where(s => s.Correo.Equals(usuario.Correo) && s.Contrasena.Equals(usuario.Contrasena));

 
                if(validar.Count()>0)
                {
                        ViewBag.error = "Acceso correcto";
                        return RedirectToAction("Index","Home");
                    }
                    else {
                        ViewBag.error = "error de datos ingresados";
                        return View("Login");
                    }
                    
                }
                else
                {
                    ViewBag.error = "error de datos";
                    return View("Login");
                }
        }
            
        }
}
