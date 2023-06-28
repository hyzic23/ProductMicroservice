using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
	public class User
	{
		public User()
		{
		}

		[Key]
		public int Id { get; set; }
		public String Username { get; set; }
        public String Password { get; set; }
    }
}

