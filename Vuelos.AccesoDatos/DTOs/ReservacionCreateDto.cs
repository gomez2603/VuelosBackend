using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.DTOs
{
    public class ReservacionCreateDto
    {
        public int VueloId { get; set; }
        public int UsuarioId { get; set; }
        public string Asientos { get; set; } =string.Empty;
        public int Total { get; set; }
        public int Estatus { get;set; }
    }
}
