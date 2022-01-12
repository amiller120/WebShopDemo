using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
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
}