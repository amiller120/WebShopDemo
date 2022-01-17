using api.Models;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ApiDataContext apiDataContext ;

    public ProductController (ApiDataContext dataContext)
	{
        _apiDataContext = dataContext
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

    [HttpGet("{id}")]
    public Product GetById(int id)
    {
        return new Product{
            Id = id,
            Description = "Description",
            Title = "Title",
            Price = 2m,
            rating = 3.5m
        };

    }
}