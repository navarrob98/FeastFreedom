using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public class SqlKitchenUsersRepository : IKitchenUsersRepository
    {
        private readonly AppDbContext context;

        public SqlKitchenUsersRepository(AppDbContext context)
        {
            this.context = context;
        }
        public KitchenUsers Add(KitchenUsers kitchenUser)
        {
            KitchenUsers aux = context.KitchenUsers.Find(kitchenUser.Email);
            KitchenUsers aux2 = context.KitchenUsers.Find(kitchenUser.Name);
            if (aux != null && aux2 != null)
            {
                context.KitchenUsers.Add(kitchenUser);
                context.SaveChanges();
                return kitchenUser;
            }
            return null;
        }

        public KitchenUsers Delete(int id)
        {
            KitchenUsers kitchenUser = context.KitchenUsers.Find(id);
            if (kitchenUser != null)
            {
                context.KitchenUsers.Remove(kitchenUser);
                context.SaveChanges();
            }
            return kitchenUser;
        }

        public IEnumerable<KitchenUsers> GetAllKitchenUsers()
        {
            return context.KitchenUsers;
        }

        public KitchenUsers GetKitchenUser(int id)
        {
            return context.KitchenUsers.Find(id);
        }

        public KitchenUsers Update(KitchenUsers kitchenUserChanges)
        {
            var kitchenUser = context.KitchenUsers.Attach(kitchenUserChanges);
            kitchenUser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return kitchenUserChanges;
        }
    
    }
}
