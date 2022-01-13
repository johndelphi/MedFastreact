using System.Collections.Generic;
namespace Shop.Data{

    public interface IshopService
    {
        List<Shops> GetAllShops();
        Shops GetShopsByTown();
        Shops GetClosest();
    }
}