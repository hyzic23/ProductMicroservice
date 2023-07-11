using System;
namespace ProductMicroserviceApi.Models.Authentication
{
	public class AuthResponse
	{
		public AuthResponse()
		{
		}

        public string Status { get; set; }
        public string Message { get; set; }
    }
}

