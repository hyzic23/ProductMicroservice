using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Models;
using ProductMicroservice_Api.IRepository;
using ProductMicroservice_Api.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        //private IGenericService<User> _service = new GenericService<User>();
        private IGenericService<User> _service;
        private IUserService _userService;
        public UserController(IGenericService<User> service, IUserService userService)
        {
            _service = service;
            _userService = userService;
        }

        [HttpGet]
        [Route("all-users")]
        public IActionResult Index()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        [Route("add-users")]
        public IActionResult AddUser(User user)
        {
            User response = _service.Add(user);
            return Ok(response);
        }

        [HttpPost]
        [Route("authenticate-users")]
        public IActionResult AuthenticateUser(User user)
        {
            User response = _userService.ValidateUserCredentials(user.Username, user.Password);
            return Ok(response);
        }
    }
}

