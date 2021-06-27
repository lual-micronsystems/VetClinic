using System.Collections.Generic;
using System.Linq;
using VetClinic.Data;
using Microsoft.AspNetCore.Mvc;
using VetClinic.Models;
using System;

namespace VetClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IAccessProvider _accessProvider;

        public UserController(IAccessProvider accessProvider)  
        {  
            _accessProvider = accessProvider;  
        }  

        [HttpGet]  
        public IEnumerable<User> GetUsers()  
        {  
            return _accessProvider.GetUsers();  
        }  
  
        [HttpPost]  
        public IActionResult CreateUser([FromBody]User user)  
        {  
            if (ModelState.IsValid)  
            {  
                Guid obj = Guid.NewGuid();  
                _accessProvider.CreateUser(user);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpGet("{userId}")]  
        public User GetUserDetails(int userId)  
        {  
            return _accessProvider.GetUser(userId);  
        }  
  
        [HttpPut]  
        public IActionResult UpdateUser([FromBody]User user)  
        {  
            if (ModelState.IsValid)  
            {  
                _accessProvider.UpdateUser(user);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{userId}")]  
        public IActionResult DeleteUser(int userId)
        {
            var data = _accessProvider.GetUser(userId);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            _accessProvider.DeleteUser(userId);  
            return Ok();
        }
        
    }
}