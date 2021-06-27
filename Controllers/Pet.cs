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
    public class PetController: ControllerBase
    {
        private readonly IAccessProvider _accessProvider;

        public PetController(IAccessProvider accessProvider)  
        {  
            _accessProvider = accessProvider;  
        }  

        [HttpGet]  
        public IEnumerable<Pet> GetPets()  
        {  
            return _accessProvider.GetPets();  
        }  
  
        [HttpPost]  
        public IActionResult CreatePet([FromBody]Pet pet)  
        {  
            if (ModelState.IsValid)  
            {  
                Guid obj = Guid.NewGuid();  
                _accessProvider.CreatePet(pet);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpGet("{petId}")]  
        public Pet GetPetDetails(int petId)  
        {  
            return _accessProvider.GetPet(petId);  
        }  
  
        [HttpPut]  
        public IActionResult UpdatePet([FromBody]Pet pet)  
        {  
            if (ModelState.IsValid)  
            {  
                _accessProvider.UpdatePet(pet);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{petId}")]  
        public IActionResult DeletePet(int petId)
        {
            var data = _accessProvider.GetPet(petId);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            _accessProvider.DeletePet(petId);  
            return Ok();
        }
    }
}