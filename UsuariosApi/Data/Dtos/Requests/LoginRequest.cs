﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos.Requests
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
