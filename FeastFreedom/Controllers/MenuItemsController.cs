using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeastFreedom.Models;
using FeastFreedom.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeastFreedom.Controllers
{
    public class MenuItemsController : Controller
    {
        private IMenuItemsRepository _menuItemsRepository;
        private IKitchenUsersRepository _kitchenUsersRepository;

        public MenuItemsController(IMenuItemsRepository menuItemsRepository, IKitchenUsersRepository kitchenUsersRepository)
        {
            _menuItemsRepository = menuItemsRepository;
            _kitchenUsersRepository = kitchenUsersRepository;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.KitchenID = id;
            return View();
        }
        [HttpPost]
        public IActionResult Create(MenuItems menuItem)
        {
            if (ModelState.IsValid)
            {
                MenuItems newItem = _menuItemsRepository.Add(menuItem);
                return RedirectToAction("Home", new { id = newItem.KitchenID });
            }
            return View();
        }

        public ViewResult Details(int id)
        {
            KitchenUsers ku = _kitchenUsersRepository.GetKitchenUser(id);
            var i = _menuItemsRepository.GetAllMenuItems();

            MenuDetailsViewModel md = new MenuDetailsViewModel()
            {
                kitchenUser = ku,
                menuItems = i
            };
            return View(md);
        }

        [HttpGet]
        public ViewResult EditItem(int id)
        {
            MenuItems menuItem = _menuItemsRepository.GetMenuItem(id);
            return View(menuItem);
        }
        [HttpPost]
        public IActionResult EditItem(MenuItems menuItem)
        {
            if (ModelState.IsValid)
            {
                MenuItems newItem = _menuItemsRepository.Update(menuItem);
                return RedirectToAction("Home", new { id = newItem.ItemID });
            }
            return View(menuItem);
        }

        [HttpGet]
        public ViewResult DeleteItem(int id)
        {
            MenuItems menuItem = _menuItemsRepository.GetMenuItem(id);
            return View(menuItem);
        }
        [HttpPost, ActionName("DeleteItem")]
        public IActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                MenuItems delItem = _menuItemsRepository.Delete(id);
                return RedirectToAction("Home");
            }
            return View();
        }
        
    }
}
