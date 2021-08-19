using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public interface IRegularUsersRepository
    {
        Regular_Users GetRegularUser(int id);
        IEnumerable<Regular_Users> GetAllRegularUsers();
        Regular_Users Add(Regular_Users regularUser);
        Regular_Users Delete(int id);
        Regular_Users Update(Regular_Users regularUserChanges);
    }
}
