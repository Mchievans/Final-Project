using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AutoFix_v1._0.Models
{
    interface IUser
    {
        IQueryable<User> User { get; }
        void RegisterUser(User user);
        User DeleteUser(string Password);
    }
}
