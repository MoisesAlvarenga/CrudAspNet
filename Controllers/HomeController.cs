using Microsoft.AspNetCore.Mvc;
using UsandoViews.Models;
using System.Linq;

namespace UsandoViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.QtdeUsuarios = Usuario.Listagem.Count();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar(int? id)
        {
            var User = new Usuario();
            if(id.HasValue)
            {
                if(Usuario.Listagem.Any(u => u.IdUsuario ==id))
                {
                    User = Usuario.Listagem.First(u => u.IdUsuario == id);
                }
            }
            return View(User);
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {

            if(usuario == null)
            {
                usuario.IdUsuario = 0;
            }
            else
            {
                 Usuario.Salvar(usuario);
            }
            return RedirectToAction("Usuarios");
           
        }

        public IActionResult Usuarios()
        {
            return View(Usuario.Listagem);
        }

         [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if(id.HasValue && Usuario.Listagem.Any(u => u.IdUsuario == id))
            {
                if(Usuario.Listagem.Any(u => u.IdUsuario ==id))
                {
                   var User = Usuario.Listagem.Single(u => u.IdUsuario == id);
                   return View(User);
                }
            }
            return RedirectToAction("Usuarios");
        }
      
        [HttpPost]
        public IActionResult Excluir(Usuario usuario)
        {
            Usuario.Excluir(usuario.IdUsuario);
            return RedirectToAction("Usuarios");
        }

    }
}