using Microsoft.AspNetCore.Mvc;
using NetCore6.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
namespace NetCore6.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }
        public ActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}