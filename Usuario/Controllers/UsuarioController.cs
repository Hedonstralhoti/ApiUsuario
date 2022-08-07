using Microsoft.AspNetCore.Mvc;
using Usuario.Model;

namespace Usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuarios> Usuarios()
        {
            return new List<Usuarios>
            {
                new Usuarios{Nome = "Hedon", Id = 1}
            };
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

        [HttpPost]

        public IActionResult Post(Usuarios usuarios)
        {
            var usuario = Usuarios();
            usuario.Add(usuarios);
            return Ok(usuario);
        }
    }
}
