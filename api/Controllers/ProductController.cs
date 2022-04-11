using api.Data;
using api.Models;
using api.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ApiDataContext _apiDataContext;
    private readonly ShopifyConfiguration _shopifyConfig;
    private readonly HttpClient _httpClient;


    public ProductController(
        ApiDataContext apiDataContext,
        IOptions<ShopifyConfiguration> shopifyConfig,
        HttpClient httpClient)
    {
        _apiDataContext = apiDataContext;
        _shopifyConfig = shopifyConfig.Value;
        _httpClient = httpClient;
    }








    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return new List<Product>{new Product
            {
                Id = 2,
                Title = "Title", 
                Description = "Description",
                Price = 2m,
                rating = 3.5m
            }
        };
    }

    [HttpPost]
    public IActionResult CreateNewProduct(Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid entry");
        }

        using (var context = _apiDataContext)
        {
            context.Products.Add(new Product()
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
                rating = product.rating
            });
            context.SaveChanges();
        }
        return Ok();
    }


    [HttpDelete]
    public IActionResult DeleteProduct(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Not a valid product Id");
        }

        using (var context = _apiDataContext)
        {
            var product = context.Products.Where(x => x.Id == id).FirstOrDefault();
            context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }

        return Ok();
    }

    [HttpGet("{id}")]
    public Product GetById(int id)
    {
        var product = _apiDataContext.Products.FirstOrDefault(product => product.Id == id);
        if (product != null)
        {
            return product;
        }
        return null;

    }
}