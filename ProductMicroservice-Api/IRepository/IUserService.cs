using System;
using ProductMicroservice.Models;

//namespace ProductMicroserviceApi.IRepository
namespace ProductMicroservice_Api.IRepository
{
	public interface IUserService
	{
		User ValidateUserCredentials(String username, String password);
		bool CheckIfUserExists(string username);
		User GetUserByName(string username);
	}
}

