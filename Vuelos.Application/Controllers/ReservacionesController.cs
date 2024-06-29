using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities.DTOs;
using Vuelos.Entities.Modelos;

namespace Vuelos.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionesController : ControllerBase
    {
        private readonly IUnidadDeTrabajo _uow;
        private readonly IMapper _map;

        public ReservacionesController(IUnidadDeTrabajo uow, IMapper map)
        {
            _uow = uow;
            _map = map;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetReservaciones([FromQuery] int Id)
        {
           
            return Ok(_uow.reservacion.ObtenerTodos(x => x.UsuarioId == Id,incluirPropiedades: "Vuelo,Usuario"));
        }

        [HttpPost]
        [Authorize]
        public IActionResult CrearReservacion([FromBody] ReservacionCreateDto reservacionCreate)
        {
            var map = _map.Map<ReservacionCreateDto,Reservaciones>(reservacionCreate);
            map.TimeSpan = DateTime.Now;
            _uow.reservacion.Agregar(map);
            _uow.Guardar();
            return Created($"/api/Reservaciones/"+map.Id, map);
        }
    }
}
