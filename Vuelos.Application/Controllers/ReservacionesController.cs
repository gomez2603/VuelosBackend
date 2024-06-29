using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
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
            var reservacion = _uow.reservacion.ObtenerTodos(x => x.UsuarioId == Id, incluirPropiedades: "Vuelo,Usuario");
            var map = _map.Map<IEnumerable<Reservaciones>, IEnumerable<ReservacionesResponseDto>>(reservacion);


            return Ok(map);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CrearReservacion([FromBody] ReservacionCreateDto reservacionCreate)
        {
            var map = _map.Map<ReservacionCreateDto, Reservaciones>(reservacionCreate);
            map.TimeSpan = DateTime.Now;
            _uow.reservacion.Agregar(map);
            _uow.Guardar();
            return Created($"/api/Reservaciones/" + map.Id, map);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult CancelarReservacion(int id)
        {
            var reservacion = _uow.reservacion.ObtenerPrimero(x=>x.Id == id,incluirPropiedades:"Vuelo");
            
            if(reservacion == null)
            {
                return NotFound();
            }
            if(reservacion.Estatus == 1)
            {
                return BadRequest("La reservacion no puede ser cancelada");
            }
            var estatus = DateTime.Compare(DateTime.Now, reservacion.TimeSpan.AddMinutes(30));
            if (estatus >  0 && reservacion.Estatus == 0)
            {
                _uow.reservacion.Remover(id);
                _uow.Guardar();
                return BadRequest("Reservacion expirada");
            }
            if(reservacion.Vuelo.Horario.AddHours(5) > DateTime.Now)
            {
                return BadRequest("Su reservacion ya no se puede cancelar");
            }
            _uow.reservacion.Remover(id);
            _uow.Guardar();
            return NoContent();
        }


        [HttpGet("pagar/{id}")]
        [Authorize]
        public IActionResult PagarReservacion(int id)
        {
            var reservacion = _uow.reservacion.ObtenerPrimero(x => x.Id == id, incluirPropiedades: "Vuelo");
            if (reservacion == null)
            {
                return NotFound();
            }
            var estatus = DateTime.Compare(DateTime.Now, reservacion.TimeSpan.AddMinutes(30));
            if (estatus > 0 && reservacion.Estatus == 0)
            {
                _uow.reservacion.Remover(id);
                _uow.Guardar();
                return BadRequest("Reservacion expirada");
            }

            reservacion.Estatus = 1;
            Guid miGuid = Guid.NewGuid();
            reservacion.Confirmacion = Convert.ToBase64String(miGuid.ToByteArray());
            _uow.reservacion.Actualizar(reservacion);
            _uow.Guardar();
            return Ok(reservacion);
        }



    }
}
