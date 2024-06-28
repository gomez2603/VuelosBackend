using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;

namespace Vuelos.Entities.Semillas
{
    public class VuelosASemilla:IEntityTypeConfiguration<VuelosA>
    {
  
        

        public void Configure(EntityTypeBuilder<VuelosA> builder)
        {
        builder.HasData(
            new VuelosA { Id = 0, Destino = "ACA", Origen = "MID", Asientos = 30, AsientosOcupados = 0, Horario = DateTime.Now.AddDays(1).AddHours(4), Precio = 400.00 },
            new VuelosA { Id = 0, Destino = "QRO", Origen = "MID", Asientos = 30, AsientosOcupados = 4, Horario = DateTime.Now.AddDays(1).AddHours(2), Precio = 800.00 },
            new VuelosA { Id = 0, Destino = "MTY", Origen = "MID", Asientos = 30, AsientosOcupados = 8, Horario = DateTime.Now.AddDays(1).AddHours(6), Precio = 2200.00 },
            new VuelosA { Id = 0, Destino = "CUN", Origen = "MID", Asientos = 30, AsientosOcupados = 12, Horario = DateTime.Now.AddDays(1).AddHours(8), Precio = 2400.00 },
            new VuelosA { Id = 0, Destino = "TCN", Origen = "MID", Asientos = 30, AsientosOcupados = 18, Horario = DateTime.Now.AddDays(1), Precio = 700.00 }
            );
        }
    }
}
