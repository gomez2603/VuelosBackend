using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;

namespace Vuelos.DataAccess.Repositorio.Interfaces
{
    public interface IVueloRepositorio:IRepositorio<VuelosA>
    {
        void Actualizar(VuelosA vuelosA);


    }
}
