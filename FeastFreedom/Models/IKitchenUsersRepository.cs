using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public interface IKitchenUsersRepository
    {
        KitchenUsers GetKitchenUser(int id);
        IEnumerable<KitchenUsers> GetAllKitchenUsers();
        KitchenUsers Add(KitchenUsers kitchenUser);
        KitchenUsers Delete(int id);
        KitchenUsers Update(KitchenUsers kitchenUserChanges);
    }
}
