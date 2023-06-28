using System.Net;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.IRepository;
using ProductMicroservice.Models;

namespace ProductMicroservice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepo;

    public ProductController(ILogger<ProductController> logger, IProductRepository productRepo)
    {
        _logger = logger;
        _productRepo = productRepo;
    }

    [HttpGet(Name = "GetAllProducts")]
    public IActionResult GetAllProducts()
    {
        var products = _productRepo.GetProducts();
        if(products == null)
            return NotFound();
        return new OkObjectResult(products);
    }

    [HttpGet(Name = "AllProducts")]
    public IActionResult Products()
    {
        var products = _productRepo.AllProducts();
        if(products == null)
            return NotFound();
        return new OkObjectResult(products);
    }

    [HttpGet("{id}", Name ="GetProductById")]
    public IActionResult GetProductById(int id)
    {
        var product = _productRepo.GetProductById(id);
        if(product == null)
            return NotFound();
        return new OkObjectResult(product);
    }

    [HttpPost(Name ="AddProduct")]
    public IActionResult AddProduct([FromBody]Product product)
    {
        _productRepo.InsertProduct(product);
        return CreatedAtAction(nameof(GetAllProducts), new { id = product.Id});
    }

    [HttpPut("UpdateProduct")]
    public IActionResult UpdateProduct([FromBody] Product product)
    {
        if(product != null)
        {
            _productRepo.UpdateProduct(product);
            return new OkResult();
        }
        return new NoContentResult();
    }

    [HttpDelete("{id}",Name ="DeleteProduct")]
    public IActionResult DeleteProduct(int id)
    {
        _productRepo.DeleteProduct(id);
        return new OkResult();
    }

}
