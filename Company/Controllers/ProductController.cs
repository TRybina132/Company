using Application.Entities;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly List<Product> products = new List<Product>
        //{
        //    new Product { Id = 0, Name = "ASP.NET API", PL = "C#", Price = 1000},
        //    new Product { Id = 1, Name = "Angular SPA app", PL = "TS", Price = 800}
        //};

        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<List<Product>?> GetProducts() =>
            await productService.GetProducts();
    }
}
