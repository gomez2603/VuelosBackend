using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.DTOs
{
    public class RegistroUsuarioDto
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RolId { get;set; } 
        

    }
}
