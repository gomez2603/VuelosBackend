using Domain.Servicios.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.Modelos;

namespace Domain.Servicios.Implementacion
{
    public class AuthServicio :IAuthService
    {
        private readonly IConfiguration _configuration;
        public AuthServicio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

        public string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Nombres),
                new Claim(ClaimTypes.Email,user.Email),
               new Claim(ClaimTypes.Role,user.Rol.Nombre)

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;

        }





        public bool VerifyPassword(string Password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHAsh = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return computedHAsh.SequenceEqual(passwordHash);
            }
        }
    }
}
