using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMicroserviceApi.Models.Authentication
{
	public class LoginModel
	{
		public LoginModel()
		{
		}

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}

