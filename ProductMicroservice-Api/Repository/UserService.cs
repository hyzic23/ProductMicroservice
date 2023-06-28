using System;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Models;
using ProductMicroservice_Api.IRepository;
//using ProductMicroserviceApi.IRepository;

//namespace ProductMicroserviceApi.Repository
namespace ProductMicroservice_Api.Repository
{
	public class UserService : IUserService
	{
        private ProductContext _context;

		public UserService(ProductContext context)
		{
            this._context = context;
		}

        public bool CheckIfUserExists(string username)
        {
            throw new NotImplementedException();
        }

        public User GetUserByName(string username)
        {
            User user = _context.Users.Where(u => u.Username == username).FirstOrDefault();
            if(user != null)
                return user;
            return null ;
        }

        public User ValidateUserCredentials(String username, String password)
        {
            User user = _context.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
                return user;
            return null;
        }
    }
}

