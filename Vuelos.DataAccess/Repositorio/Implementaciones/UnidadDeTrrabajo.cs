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
        public IUsuarioRepositorio usuario { get; private set; }
        public IVueloRepositorio vuelo { get; private set; }
        public IReservacionRepositorio reservacion { get; private set; }
        public UnidadDeTrrabajo(VuelosContext context)
        {
            _context = context;
            usuario = new UsuariosRepositorio(_context);
            vuelo = new VuelosRepositorio(_context);
            reservacion = new ReservacionesRepositorio(_context);
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
