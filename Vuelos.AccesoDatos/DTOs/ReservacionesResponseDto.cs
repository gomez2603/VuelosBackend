using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.DTOs
{
    public class ReservacionesResponseDto
    {
        public int Id { get; set; }
        public int VueloId { get; set; }
        public string VueloDestino { get; set; }
        public string VueloHorario { get; set; }
        public string VueloDuracionViaje { get; set; }
        public string Asientos { get; set; }
        public int total { get; set; }
        public int estatus { get; set; }
        public string Confirmacion { get; set; }
    }
}
