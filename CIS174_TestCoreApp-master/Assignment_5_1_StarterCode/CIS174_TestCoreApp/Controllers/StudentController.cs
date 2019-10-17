using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
   
    public class StudentController: Controller
    {
        public IActionResult Index([FromRoute]int id)
        {
            var studentsList = new List<StudentViewModel>
            {
                new StudentViewModel {FirstName ="Billy", LastName = "Bob", Grade = 73},
                new StudentViewModel {FirstName ="Bob", LastName = "Bill", Grade = 69},
                new StudentViewModel {FirstName ="Flippy", LastName = "Flop", Grade = 82},
                new StudentViewModel {FirstName ="Tim", LastName = "Nerd", Grade = 94}
            };

            var viewModel = new ViewModel
                            {
                                AccessLevel = id,
                                Students = studentsList
                            };
            
            return View(viewModel);
        }
    }
}
