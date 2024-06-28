using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;
using Vuelos.Entities.Semillas;

namespace Vuelos.Entities
{
    public class VuelosContext : DbContext
    {
        public VuelosContext(DbContextOptions<VuelosContext> options) : base(options)
        {

        }

        public DbSet<VuelosA> Vuelos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reservaciones> Reservaciones { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new VuelosASemilla());
        }
    }

}
