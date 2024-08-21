using ASP.NetEmpty.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetEmpty.Controllers
{
    public class HomeController : Controller

    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
    }
}
