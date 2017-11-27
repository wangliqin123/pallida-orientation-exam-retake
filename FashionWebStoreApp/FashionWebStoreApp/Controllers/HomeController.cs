using Microsoft.AspNetCore.Mvc;
using FashionWebStoreApp.Services;

namespace FashionWebStoreApp.Controllers
{
    public class HomeController : Controller
    {
        FashionStoreService FashionStoreService;

        public HomeController(FashionStoreService fashionStoreService)
        {
            FashionStoreService = fashionStoreService;
        }

        [HttpGet]
        [Route("/warehouse")]
        public IActionResult Index()
        {
            return View(FashionStoreService.GetWarehouseItemList());
        }

        [HttpPost]
        [Route("/warehouse/summary")]
        public IActionResult Summary(int amount)
        {
            return View();
        }

        [HttpGet]
        [Route("/warehouse/query")]
        public IActionResult ApiQuery([FromQuery]int price, [FromQuery]string type)
        {
            return Json(new { result = "ok", clothes = FashionStoreService.GetWarehouseItemListApi(price, type)});
        }
    }
}