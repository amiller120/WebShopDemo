using api.Data;
using api.Models.Shopify.Products;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ApiDataContext _apiDataContext;
    private readonly IProductService _shopifyService;


    public ProductController(
        ApiDataContext apiDataContext,
        IProductService shopifyService)
    {
        _apiDataContext = apiDataContext;
        _shopifyService = shopifyService;
    }



    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _shopifyService.GetProducts();
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewBasicProduct(Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid entry");
        }
        
        var responseObject = await _shopifyService.CreateNewBasicProduct(product);

        if (responseObject != null)
        {
            return StatusCode(200);
        }
        else
        {
            return StatusCode(400);
        }
    }

    [HttpGet("{id}")]
    public async Task<Product?> GetById(long id)
    {
        var product = await _shopifyService.GetProductById(id);
        if (product != null)
        {
            return product;
        }
        return null;

    }
}