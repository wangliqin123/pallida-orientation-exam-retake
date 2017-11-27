using FashionWebStoreApp.Models;
using FashionWebStoreApp.Repositories;
using System.Collections.Generic;

namespace FashionWebStoreApp.Services
{
    public class FashionStoreService
    {
        FashionStoreRepository FashionStoreRepository;

        public FashionStoreService(FashionStoreRepository fashionStoreRepository)
        {
            FashionStoreRepository = fashionStoreRepository;
        }

        public List<Warehouse> GetWarehouseItemList()
        {
            return FashionStoreRepository.GetAllItemList();
        }

        public List<Warehouse> GetWarehouseItemListApi(int price, string type)
        {
            return FashionStoreRepository.GetClothesListJson(price, type);
        }

        public List<Warehouse> GetSelectedItemInfo(int amount, string selectedItem, string selectedSize)
        {
            return FashionStoreRepository.GetSelectedItem(amount, selectedItem, selectedSize);
        }
    }
}