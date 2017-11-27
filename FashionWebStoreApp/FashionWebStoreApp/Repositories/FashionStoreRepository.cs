using FashionWebStoreApp.Entities;
using FashionWebStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionWebStoreApp.Repositories
{
    public class FashionStoreRepository
    {
        FashionStoreContext FashionStoreContext;

        public FashionStoreRepository(FashionStoreContext fashionStoreContext)
        {
            FashionStoreContext = fashionStoreContext;
        }

        public List<Warehouse> GetAllItemList()
        {
            return FashionStoreContext.Warehouses.ToList();
        }

        public List<Warehouse> GetClothesWithUnitPriceLowerThan50()
        {
            return FashionStoreContext.Warehouses.Where(x => x.UnitPrice < 50).ToList();
        }
    }
}
