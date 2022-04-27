using AspNetMVC.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        public ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult List()
        {
            ViewData["ProductList"] = _productService.GetCatalog();
            ViewData["GrandTotal"] = _productService.GetGrandTotal();

            return View();
        }
    }
}
