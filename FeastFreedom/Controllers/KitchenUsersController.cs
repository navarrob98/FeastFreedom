using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeastFreedom.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeastFreedom.Controllers
{
    public class KitchenUsersController : Controller
    {
        private IKitchenUsersRepository _kitchenUsersRepository;

        public KitchenUsersController(IKitchenUsersRepository kitchenUsersRepository)
        {
            _kitchenUsersRepository = kitchenUsersRepository;
        }



        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(KitchenUsers kitchenUser)
        {
            if (ModelState.IsValid)
            {
                KitchenUsers newUser = _kitchenUsersRepository.Add(kitchenUser);
                return RedirectToAction("Home", new { id = newUser.KitchenID });
            }
            return View();
        }

        [HttpGet]
        public ViewResult editKitchen(int id)
        {
            KitchenUsers kitchenUser = _kitchenUsersRepository.GetKitchenUser(id);
            return View(kitchenUser);
        }
        [HttpPost]
        public IActionResult editKitchen(KitchenUsers kitchenUser)
        {
            if (ModelState.IsValid)
            {
                KitchenUsers newUser = _kitchenUsersRepository.Update(kitchenUser);
                return RedirectToAction("Home", new { id = newUser.KitchenID });
            }
            return View(kitchenUser);
        }
    }
}
