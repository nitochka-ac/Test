using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Entity;

namespace Shop.DataBase
{
    class SHContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public SHContext() : base("ShopConnection")
        {

        }
    }
}
