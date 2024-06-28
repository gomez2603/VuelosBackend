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
    public class RolSemilla : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData(
                new Rol() { Id=1, Nombre= "BASICA"},
                new Rol() { Id=2, Nombre= "PREMIUM"}
               
                );
        }
    }
}
