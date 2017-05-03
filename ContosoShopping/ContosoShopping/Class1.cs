using Contoso.Base;
using System;

namespace ContosoShopping
{
    public class Class1
    {
        public static string GetVersion()
        {
            return "Contoso Shopping 1.0.0 (NETStandard)";
        }

        public static ShopCart GetShoppingCart(Guid userId)
        {
            ShopCart shopCart = new ShopCart(userId);
            return shopCart;
        }

    }
}
