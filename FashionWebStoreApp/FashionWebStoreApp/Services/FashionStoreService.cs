using FashionWebStoreApp.Models;
using FashionWebStoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
