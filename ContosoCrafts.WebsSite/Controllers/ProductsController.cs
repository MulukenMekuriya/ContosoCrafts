using ContosoCrafts.WebSite.Services;
using ContosoCrafts.WebsSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebsSite.Controllers
{
    [Route("[controller")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService prodcutService)
        {
            this.productService = prodcutService;
        }

        public JsonFileProductService productService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }
    }
}
