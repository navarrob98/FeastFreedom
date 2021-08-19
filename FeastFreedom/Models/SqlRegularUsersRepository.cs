using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public class SqlRegularUsersRepository : IRegularUsersRepository
    {
        private readonly AppDbContext context;

        public SqlRegularUsersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Regular_Users Add(Regular_Users regularUsers)
        {
            Regular_Users aux = context.Regular_Users.Find(regularUsers.Email);

            if (aux != null)
            {
                context.Regular_Users.Add(regularUsers);
                context.SaveChanges();
                return regularUsers;
            }
            return null;
        }

        public Regular_Users Delete(int id)
        {
            Regular_Users regularUsers = context.Regular_Users.Find(id);
            if (regularUsers != null)
            {
                context.Regular_Users.Remove(regularUsers);
                context.SaveChanges();
            }
            return regularUsers;
        }

        public IEnumerable<Regular_Users> GetAllRegularUsers()
        {
            return context.Regular_Users;
        }

        public Regular_Users GetRegularUser(int id)
        {
            return context.Regular_Users.Find(id);
        }

        public Regular_Users Update(Regular_Users regularUserChanges)
        {
            var regularUser = context.Regular_Users.Attach(regularUserChanges);
            regularUser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return regularUserChanges;
        }
    }
}
