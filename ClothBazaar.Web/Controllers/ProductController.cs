using ClothBazaar.Entity;
using ClothBazaar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazaar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductServices services = new ProductServices();

        [HttpGet]
        public ActionResult Index()
        {
            List<Product> products = services.GetCategory();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            services.SaveCategory(product);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = services.GetCategory(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            services.UpdateCategory(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product product = services.GetCategory(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            services.DeleteCategory(product);
            return RedirectToAction("Index");
        }

    }
}