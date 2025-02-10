using BibliotecaDiegoAleman.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDiegoAleman.Controllers
{

    public class UsuarioController : Controller
    {
        private readonly IUsuarioServices _usuarioServices;
        
        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;


        }

        public IActionResult Index()
        {
            var result = _usuarioServices.ObtenerUsuario();
            return View(result);
        }


    }
}
