using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;

namespace Northwind.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ProductsController : Controller
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
