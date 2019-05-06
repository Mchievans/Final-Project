using System;
using System.Linq;

namespace AutoFix_v1._0.Models
{
    public class EFShop : IShop
    {
        private AutoFixContext context;

        public EFShop(AutoFixContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Shop> Shop => context.Shop;

        public User DeleteShop(string Password)
        {
            throw new NotImplementedException();
        }

        public void RegisterShop(Shop shop)
        {
            throw new NotImplementedException();
        }

    }
}

