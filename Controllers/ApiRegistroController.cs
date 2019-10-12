using System.Linq;
using System.Threading.Tasks;
using jave_dotnet_mvc.Data;
using jave_dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace jave_dotnet_mvc.Controllers {

    [Route ("api/registro")]
    [ApiController]
    public class ApiRegistroController : ControllerBase {
        private readonly ApplicationDbContext _context;

        public ApiRegistroController (ApplicationDbContext context) {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioViewModel>> PostUsuario (UsuarioViewModel user) {
            if (ModelState.IsValid) {
                return Ok ();
            }

            return BadRequest ();
        }

        [HttpGet]
        [Route ("usuario")]
        public async Task<ActionResult> GetUsuario () {
            
            var usuario = new UsuarioViewModel {
                Input = {
                    Nombres = "yesid",
                    Apellidos = "Gutierrez",
                    Correo = "yesid.gutierrez@prueba.com",
                    Direccion = "Kra 51"
                }
            };
            return Ok (usuario);
        }
    }
}