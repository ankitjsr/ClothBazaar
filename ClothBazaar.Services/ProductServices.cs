using ClothBazaar.Data;
using ClothBazaar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazaar.Services
{
    public class ProductServices
    {
        public List<Product> GetCategory()
        {

            using (BazaarContext context = new BazaarContext())
            {
                return (context.Products.ToList());
            }
        }

        public Product GetCategory(int id)
        {

            using (BazaarContext context = new BazaarContext())
            {
                return (context.Products.Find(id));
            }
        }


        public void SaveCategory(Product product)
        {
        
            using (BazaarContext context = new BazaarContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Product product)
        {

            using (BazaarContext context = new BazaarContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Product product)
        {

            using (BazaarContext context = new BazaarContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
