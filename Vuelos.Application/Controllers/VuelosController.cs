using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vuelos.DataAccess.Repositorio.Interfaces;

namespace Vuelos.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : ControllerBase
    {
        private readonly IUnidadDeTrabajo _uow;

        public VuelosController(IUnidadDeTrabajo uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? destino)
        {
            if(destino == null)
            {
                return Ok(_uow.vuelo.ObtenerTodos());
            }
            else
            {
                return Ok(_uow.vuelo.ObtenerTodos(filter:x=>x.Destino ==destino));
            }
           
        }
        [HttpGet("{id}")] 
        public IActionResult GetOne(int id)
        {
            return Ok(_uow.vuelo.ObtenerPrimero(x => x.Id == id));
        }
    }
}
