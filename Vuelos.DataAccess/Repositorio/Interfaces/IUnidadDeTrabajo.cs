using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.DataAccess.Repositorio.Interfaces
{
    public interface IUnidadDeTrabajo:IDisposable
    {
        IUsuarioRepositorio usuario { get; }
        IVueloRepositorio vuelo { get; }
        IReservacionRepositorio reservacion { get; }


        void Guardar();
    }
}
