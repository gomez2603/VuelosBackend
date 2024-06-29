using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.Modelos
{
    public class Reservaciones
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VueloId { get; set; }
        [ForeignKey("VueloId")]
        public virtual VuelosA? Vuelo { get; set; }
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario {get;set;}
        public string Asientos { get; set; }
        public DateTime TimeSpan { get; set; } = DateTime.Now;
        public int Total { get; set; }
        
        public int Estatus { get; set; } = 0;   
        public string Confirmacion { get; set; } = string.Empty;

    }
}
