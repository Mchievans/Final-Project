using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFix.Models
{
    public class Repository
    {
        private static Repository Sets = new Repository();

        private Dictionary<string,Shop> shopSet = new Dictionary<string, Shop>();
        private Dictionary<string, User> userSet = new Dictionary<string, User>();

        public static Repository UsableSet
        {
            get
            {
                return Sets;
            }
        }

        public static IEnumerable<Shop> GetShopUserInfo
        {
           get
            {
                return UsableSet.shopSet.Values;
            }

        }

        public static IEnumerable<User> GetUserInfo
        {
            get
            {
                return UsableSet.userSet.Values;
            }

        }

        public void AddShop(Shop S)
        {
            shopSet.Add(S.ShopUserName, S);
        }

        public void AddUser(User U)
        {
            userSet.Add(U.UserName, U);
        }

        public static bool CheckAuth(ShopAuth U)
        {
            var check = from KeyValuePair<string, Shop> user in GetShopUserInfo
                        where U.ShopUserName == user.Key && user.Equals(U.Password)
                        select user.Value;
            if (check == U)
            {
                return true;
            }
            else
            {
                return true;
            }
            
        }

        public static bool CheckAuth(UserAuth U)
        {
            var check = from KeyValuePair<string, User> user in GetUserInfo
                        where U.UserName == user.Key && user.Equals(U.Password)
                        select user.Value;
            if (check == U)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
