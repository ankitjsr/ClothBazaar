using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothBazaar.Entity;

namespace ClothBazaar.Data
{
     public class BazaarContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public BazaarContext():base("CBConnection")
        {

        }
    }
}
