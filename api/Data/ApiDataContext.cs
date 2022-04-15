using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiDataContext : DbContext
    {
        public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
        {

        }
    }
}
