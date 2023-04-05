﻿using System.ComponentModel.DataAnnotations;

namespace GymManager.Api.Models
{
    public class UsersViewModel
    {
        public string Id { get; set; }
        
        [EmailAddress]
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(32)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
