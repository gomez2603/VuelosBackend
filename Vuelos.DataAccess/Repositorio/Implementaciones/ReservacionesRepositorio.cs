using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities;
using Vuelos.Entities.Modelos;

namespace Vuelos.DataAccess.Repositorio.Implementaciones
{
    public class ReservacionesRepositorio:Repositorio<Reservaciones>,IReservacionRepositorio
    {
        private readonly VuelosContext _db;
        public ReservacionesRepositorio(VuelosContext db):base(db)
        {
            _db = db;                    
        }

        public void Actualizar(Reservaciones reservaciones)
        {
            var reservacionesDb  = _db.Reservaciones.FirstOrDefault(x=> x.Id == reservaciones.Id);
            if(reservacionesDb != null)
            {
                reservacionesDb.VueloId = reservaciones.VueloId;
                reservacionesDb.UsuarioId = reservaciones.UsuarioId;
                reservacionesDb.Asiento = reservaciones.Asiento;
                _db.Reservaciones.Update(reservacionesDb);
            }
        }


    }
}
