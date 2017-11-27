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

        public int GetAmountOfSelectedItem(string itemName)
        {
            int quantity;
            return quantity = FashionStoreContext.Warehouses.Count(x => x.ItemName.Equals(itemName));          
        }

        public double GetTotalPriceOfSelectedItem(string itemName)
        {
            double totalprice;
            return totalprice = FashionStoreContext.Warehouses.Where(x => x.ItemName.Equals(itemName)).Sum(x => x.UnitPrice);
        }

     
    }
}
