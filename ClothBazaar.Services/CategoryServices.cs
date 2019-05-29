using ClothBazaar.Data;
using ClothBazaar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazaar.Services
{
    public class CategoryServices
    {
        public List<Category> GetCategory()
        {

            using (BazaarContext context = new BazaarContext())
            {
                return (context.Categories.ToList());
            }
        }

        public Category GetCategory(int id)
        {

            using (BazaarContext context = new BazaarContext())
            {
                return (context.Categories.Find(id));
            }
        }


        public void SaveCategory(Category category)
        {
        
            using (BazaarContext context = new BazaarContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {

            using (BazaarContext context = new BazaarContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {

            using (BazaarContext context = new BazaarContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
