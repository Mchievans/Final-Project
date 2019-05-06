using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFix_v1._0.Models
{
    public class EFUser : IUser
    {
        private AutoFixContext context;

        public EFUser(AutoFixContext ctx)
        {
            context = ctx;
        }

        public IQueryable<User> User => context.User;

        public User DeleteUser(string Password)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
