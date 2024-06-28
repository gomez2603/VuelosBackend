using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;

namespace Vuelos.DataAccess.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio:IRepositorio<Usuario>
    {
        void Actualizar(Usuario usuario);
    }
}
