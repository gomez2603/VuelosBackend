using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.Modelos
{
    public class VuelosA
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Destino { get; set; } = String.Empty;
        public string Origen { get; set; } = "MID";
        public int Asientos { get; set; } = 30;
        public int AsientosOcupados { get; set; } = 0;
        [Required]
        public DateTime Horario { get; set; }
        public double Precio { get; set; } 

    }
}
