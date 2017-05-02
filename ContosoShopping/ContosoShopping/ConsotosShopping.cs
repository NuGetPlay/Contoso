using Contoso.Base;
using System;

namespace ContosoShopping
{
    public class ContosoShopping
    {
        public static string GetVersion()
        {
            return "Contoso Shopping 1.0.5 (NETStandard)";
        }

        public static ShopCart GetShoppingCart(Guid userId)
        {
            ShopCart shopCart = new ShopCart(userId);
            return shopCart;
        }

    }
}
