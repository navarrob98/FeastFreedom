using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public interface IMenuItemsRepository
    {
        MenuItems GetMenuItem(int id);
        IEnumerable<MenuItems> GetAllMenuItems();
        MenuItems Add(MenuItems menuItem);
        MenuItems Delete(int id);
        MenuItems Update(MenuItems menuItemChanges);
    }
}
