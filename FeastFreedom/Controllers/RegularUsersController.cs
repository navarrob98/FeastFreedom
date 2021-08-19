using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeastFreedom.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeastFreedom.Controllers
{
    public class RegularUsersController : Controller
    {
        private IRegularUsersRepository _regularUsersRepository;

        public RegularUsersController(IRegularUsersRepository regularUsersRepository)
        {
            _regularUsersRepository = regularUsersRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Regular_Users regularUser)
        {
            if (ModelState.IsValid)
            {
                Regular_Users newUser = _regularUsersRepository.Add(regularUser);
                return RedirectToAction("Home", new { id = newUser.UserID });
            }
            return View();
        }


    }
}
