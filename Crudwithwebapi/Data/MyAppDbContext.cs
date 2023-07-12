
using Crudwithwebapi.Models;
using Microsoft.EntityFrameworkCore;

namespace Crudwithwebapi.Data
{
    public class MyAppDbContext:DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }


    }
}
                     