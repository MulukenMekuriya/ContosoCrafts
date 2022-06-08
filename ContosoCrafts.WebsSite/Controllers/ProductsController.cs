using ContosoCrafts.WebSite.Services;
using ContosoCrafts.WebsSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebsSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
