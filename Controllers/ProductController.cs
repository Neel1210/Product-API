using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;
using ProductAPI.Respository;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]  
    //attribute base routing
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;

        //consttructor
        public ProductController(IProductRepository productRepositroy)
        {
            _productRepository = productRepositroy;
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            List<Product>allProducts=_productRepository.GetAllProducts();
            return Ok(allProducts);
        }

        [Route("addProduct")]
        [HttpPost]
        public  ActionResult AddProduct(Product product)
        {
            bool addProdcutStatus = _productRepository.AddProduct(product);
            return Created("api/Created", addProdcutStatus);
        }

        [Route("removeProduct")]
        [HttpDelete]
        public ActionResult RemoveProduct(Product product)
        {
            bool removeProdcutStatus = _productRepository.RemoveProduct(product);
            return Created("api/Created", removeProdcutStatus);
        }
    }
}
