using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazaar.Entity
{
    public class Category:BaseEntity
    {
        public List<Product> Product { get; set; }
    }
}
