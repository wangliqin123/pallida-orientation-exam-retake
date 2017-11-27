using FashionWebStoreApp.Entities;
using FashionWebStoreApp.Models;
using System.Collections.Generic;
using System.Linq;

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

        public List<Warehouse> GetClothesListJson(int price, string type)
        {
            if (type.Equals("lower"))
            {
                return FashionStoreContext.Warehouses.Where(x => x.UnitPrice < price).ToList();
            }
            else if (type.Equals("higher"))
            {
                return FashionStoreContext.Warehouses.Where(x => x.UnitPrice > price).ToList();
            }
            else
            {
                return FashionStoreContext.Warehouses.Where(x => x.UnitPrice.Equals(price)).ToList();
            }
        }

        public Warehouse GetSelectedItem(string selectedItem)
        {
            return FashionStoreContext.Warehouses.FirstOrDefault(x => x.ItemName.Equals(selectedItem));
        } 
    }
}