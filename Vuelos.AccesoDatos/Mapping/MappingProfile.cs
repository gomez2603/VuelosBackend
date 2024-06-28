using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Entities.DTOs;
using Vuelos.Entities.Modelos;

namespace Vuelos.Entities.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<Usuario, UsuarioLoginDto>();
            CreateMap<Usuario, RegistroUsuarioDto>().ReverseMap();
            CreateMap<Usuario, RespuestaUsuarioDTO>();
            CreateMap<Usuario, UsuariroCreadoResponse>();

        }
    }
}
