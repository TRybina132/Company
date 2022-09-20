using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace Presentation.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await productService.GetAllProducts());
        }
    }
}
