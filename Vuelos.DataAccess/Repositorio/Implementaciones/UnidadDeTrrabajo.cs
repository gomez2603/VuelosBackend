using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities;

namespace Vuelos.DataAccess.Repositorio.Implementaciones
{
    public class UnidadDeTrrabajo:IUnidadDeTrabajo
    {
        private readonly VuelosContext _context;
        public UnidadDeTrrabajo(VuelosContext context)
        {
            _context = context;
        }

        public void Guardar()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
