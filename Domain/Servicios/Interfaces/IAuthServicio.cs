using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;

namespace Domain.Servicios.Interfaces
{
    public interface IAuthService
    {
        string CreateToken(Usuario user);

        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

        bool VerifyPassword(string Password, byte[] passwordHash, byte[] passwordSalt);

    }
}
