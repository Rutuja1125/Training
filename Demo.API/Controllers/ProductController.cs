using Demo.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {

        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetProducts()
        {
            List<Product> productslist = new List<Product>();

           Product? products = null;
            products = new Product { Id = 1, Name = "Product 1", Brand = "Brand 1", Price = 100, Quantity = 1 };

            productslist.Add(products);

            return Ok(products);
        }
    }
}
