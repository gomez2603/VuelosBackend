using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.DataAccess.Repositorio.Interfaces
{
    public interface IRepositorio<T>
    {
        T Obtener(int id);

        IEnumerable<T> ObtenerTodos(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string incluirPropiedades = ""
            );

        T ObtenerPrimero(
            Expression<Func<T, bool>> filter = null,
            string incluirPropiedades = ""
            );

        void Agregar(T entidad);

        void Remover(int id);

        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
    }
}
