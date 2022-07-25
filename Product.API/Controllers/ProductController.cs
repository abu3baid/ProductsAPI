using Microsoft.AspNetCore.Mvc;
using Product.API.Service;

namespace Product.API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Ok");
        }
    }
}
