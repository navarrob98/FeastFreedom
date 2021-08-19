using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public class SqlMenuItemsRepository : IMenuItemsRepository
    {
        private readonly AppDbContext context;

        public SqlMenuItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public MenuItems Add(MenuItems menuItems)
        {
            context.MenuItems.Add(menuItems);
            context.SaveChanges();
            return menuItems;
        }

        public MenuItems Delete(int id)
        {
            MenuItems menuItems = context.MenuItems.Find(id);
            if (menuItems != null)
            {
                context.MenuItems.Remove(menuItems);
                context.SaveChanges();
            }
            return menuItems;
        }

        public IEnumerable<MenuItems> GetAllMenuItems()
        {
            return context.MenuItems;
        }

        public MenuItems GetMenuItem(int id)
        {
            return context.MenuItems.Find(id);
        }

        public MenuItems Update(MenuItems menuItemsChanges)
        {
            var menuItems = context.MenuItems.Attach(menuItemsChanges);
            menuItems.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return menuItemsChanges;
        }
    }
}
