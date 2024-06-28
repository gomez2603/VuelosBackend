
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities;
using Vuelos.Entities.Modelos;


namespace Vuelos.DataAccess.Repositorio.Implementaciones
{
    public class VuelosRepositorio : Repositorio<VuelosA>, IVueloRepositorio
    {
        private readonly VuelosContext _db;
        public VuelosRepositorio(VuelosContext db) :base(db)
        {
            _db = db;
        }
        public void Actualizar(VuelosA vuelos)
        {
            var vuelosDb = _db.Vuelos.FirstOrDefault(x => x.Id == vuelos.Id);
            if(vuelosDb != null)
            {
                vuelosDb.Destino = vuelos.Destino;
                vuelosDb.Origen = vuelos.Origen;
                vuelosDb.Asientos = vuelos.Asientos;
                vuelosDb.AsientosOcupados = vuelos.AsientosOcupados;
                vuelosDb.Horario = vuelos.Horario;
                vuelosDb.Precio = vuelos.Precio;
                _db.Vuelos.Update(vuelosDb);
            }
        
                
        }

    
    }
}
