using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamousPeopleController : Controller
    {
        
        

        public IEnumerable<FamousPersonViewModel> famousPeoples { get; } = new List<FamousPersonViewModel>
        {new FamousPersonViewModel {Id = 1,
                              FName = "Adam",
                              LName =  "Sandler",
                              DOB = new DateTime(1966, 9, 9),
                              City = "LA",
                              State =  "CA",         
                              ListOfAccoplishments = "Actor"+" Comedian"+" Director"},
         new FamousPersonViewModel {Id = 2,
                              FName = "Kevin",
                              LName =  "James",
                              DOB = new DateTime(1965, 4, 25),
                              City = "LA",
                              State =  "CA",
                              ListOfAccoplishments = "Actor"+" Comedian"+" Screenwriter"+ " Producer"}
        };
        
         
        [HttpGet("{id}")]
        public FamousPersonViewModel Get(int id)
        {
            var famousPerson = famousPeoples.FirstOrDefault(x => x.Id == id);
            if(famousPerson != null) return famousPerson;

            return null;
        }
    //Definately wasn't getting this HttpPost/create verb to work correctly unless working correctly is having postmates tell me its an {
    //"": [
    //   "The input was not valid."
    //]
    //}
    [HttpPost("{create}")]
        public IActionResult Post(FamousPersonViewModel model)
        {
            if(ModelState.IsValid)
            {
                return StatusCode(201);
            }

            return BadRequest();
        }
    }
}
