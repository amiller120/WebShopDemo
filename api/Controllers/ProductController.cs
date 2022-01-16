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

    [HttpGet("{id}")]
    public Product GetById(int id)
    {
        return new Product{
            Id = id,
            Description = "Description for the produce will go in this property.",
            Title = "Jake Busey",
            Price = 2m,
            rating = 3.5m
        };

    }
}