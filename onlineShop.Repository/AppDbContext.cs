using Microsoft.EntityFrameworkCore;
using onlineShop.Repository.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Repository
{
  
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Product> Product { get; set; }
        }
    
}
