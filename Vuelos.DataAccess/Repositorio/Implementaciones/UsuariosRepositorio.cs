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
    public class UsuariosRepositorio:Repositorio<Usuario>,IUsuarioRepositorio
    {
        private readonly VuelosContext _db;
        public UsuariosRepositorio(VuelosContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Usuario usuario)
        {
            var usuarioDb = _db.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            if (usuarioDb != null)
            {
                usuarioDb.Nombres = usuario.Nombres;
                usuarioDb.Apellidos = usuario.Apellidos;
                usuarioDb.PasswordHash = usuario.PasswordHash;
                usuarioDb.PasswordSalt = usuario.PasswordSalt;
                usuarioDb.Email = usuario.Email;
                _db.Usuarios.Update(usuarioDb);
            }
          

        }
    }
}
