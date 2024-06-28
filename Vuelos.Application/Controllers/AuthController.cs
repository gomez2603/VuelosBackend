using AutoMapper;
using Domain.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities.DTOs;
using Vuelos.Entities.Modelos;

namespace Vuelos.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnidadDeTrabajo _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public AuthController(IConfiguration configuration, IUnidadDeTrabajo uow, IMapper mapper, IAuthService authService)
        {
            _configuration = configuration;
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
        }

        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Registro(RegistroUsuarioDto request)
        {
            _authService.CreatePasswordHash(request.Contrasena, out byte[] passwordHash, out byte[] passwordSalt);
            var user = _mapper.Map<Usuario>(request);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _uow.usuario.Agregar(user);
            _uow.Guardar();
            var map= _mapper.Map<UsuariroCreadoResponse>(user);
            return Created($"/api/[contrroller]/" + map.Id, map);
        }

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Login(UsuarioLoginDto login)
        {
            var user = _uow.usuario.ObtenerPrimero(u => u.Email == login.Email, incluirPropiedades: "Rol");
            if(user == null)
            {
                return NotFound();
            }
            if (!_authService.VerifyPassword(login.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Contraseña Incorrecta");    
            }
            string token = _authService.CreateToken(user);
            var userResponse = _mapper.Map<Usuario, RespuestaUsuarioDTO>(user);
            userResponse.Token = token;
            return Ok(userResponse);
        }






    }
}
