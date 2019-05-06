using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFix_v1._0.Models
{
    interface IShop
    {
        IQueryable<Shop> Shop { get; }
        void RegisterShop(Shop shop);
        User DeleteShop(string Password);
    }
}
