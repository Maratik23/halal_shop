﻿using System.ComponentModel.DataAnnotations;

namespace HalalDelivery.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
         
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}