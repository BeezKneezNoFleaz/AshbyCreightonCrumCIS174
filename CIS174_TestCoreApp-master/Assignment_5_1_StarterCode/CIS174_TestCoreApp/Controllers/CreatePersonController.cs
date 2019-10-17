using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class CreatePersonController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CreatingPersonViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(CreatingPersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
