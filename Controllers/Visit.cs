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
    public class VisitController: ControllerBase
    {
        private readonly IAccessProvider _accessProvider;

        public VisitController(IAccessProvider accessProvider)  
        {  
            _accessProvider = accessProvider;  
        }  

        [HttpGet]  
        public IEnumerable<Visit> GetVisits()  
        {  
            return _accessProvider.GetVisits();  
        }  
  
        [HttpPost]  
        public IActionResult CreateVisit([FromBody]Visit visit)  
        {  
            if (ModelState.IsValid)  
            {  
                Guid obj = Guid.NewGuid();  
                _accessProvider.CreateVisit(visit);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpGet("{visitId}")]  
        public Visit GetVisitDetails(int visitId)  
        {  
            return _accessProvider.GetVisit(visitId);  
        }  
  
        [HttpPut]  
        public IActionResult UpdateVisit([FromBody]Visit visit)  
        {  
            if (ModelState.IsValid)  
            {  
                _accessProvider.UpdateVisit(visit);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{visitId}")]  
        public IActionResult DeleteVisit(int visitId)
        {
            var data = _accessProvider.GetVisit(visitId);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            _accessProvider.DeleteVisit(visitId);  
            return Ok();
        }
    }
}