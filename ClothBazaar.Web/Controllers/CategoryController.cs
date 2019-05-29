using ClothBazaar.Entity;
using ClothBazaar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazaar.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices services = new CategoryServices();

        public ActionResult Index()
        {
            List<Category> Category = services.GetCategory();
            return View(Category);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            services.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category =  services.GetCategory(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            services.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Category category = services.GetCategory(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            services.DeleteCategory(category);
            return RedirectToAction("Index");
        }




    }
}