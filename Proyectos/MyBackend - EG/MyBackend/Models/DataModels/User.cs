﻿using System.ComponentModel.DataAnnotations;

namespace ApiBackend.Models.DataModels
{
    public class User:BaseEntity
    {
        [Required,StringLength(50)]  
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
