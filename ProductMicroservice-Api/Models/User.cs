using System;
namespace ProductMicroservice.Models
{
	public class User
	{
		public User()
		{
		}

		public int Id { get; set; }
		public String Username { get; set; }
        public String Password { get; set; }
    }
}

