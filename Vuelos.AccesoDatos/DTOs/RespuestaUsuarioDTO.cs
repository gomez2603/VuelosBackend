using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.DTOs
{
    public class RespuestaUsuarioDTO
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string RolNombre { get; set; }
        public string Token { get; set; }
    }
}
