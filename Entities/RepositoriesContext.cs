using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPIDemo.Model;

namespace WepAPIDemo.Repositories
{
    public class RepositoriesContext : DbContext
    {

       
            public RepositoriesContext(DbContextOptions options) : base(options) { }

            public DbSet<Product> Products { get; set; }

        


    }
}
