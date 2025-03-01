﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Entities.Modelos
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombres { get; set; } 
        [Required]
        [MaxLength(50)]
        public string Apellidos { get; set; } 
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public string Email { get; set; }
        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol? Rol { get; set; }
    }
}
