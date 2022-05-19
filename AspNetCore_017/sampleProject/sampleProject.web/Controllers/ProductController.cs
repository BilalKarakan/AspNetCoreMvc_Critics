using Microsoft.AspNetCore.Mvc;
using sampleProject.web.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace sampleProject.web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, ProductName = "A Product", Quantity = 10 },
                new Product { Id = 2, ProductName = "B Product", Quantity = 15 },
                new Product { Id = 3, ProductName = "C Product", Quantity = 20 }
            };

            #region Model Bazlı Veri Gönderimi
            //return View(products);


            #endregion
            #region Veri Taşıma Kontrolleri
            #region ViewBag
            ViewBag.products = products;
            

            #endregion 
            #region ViewData
            ViewData["products"] = products;
            

            #endregion
            #region TempData

            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;
            
            //TempData["products"] = products;

            // TempData["x"] = 5;
            // ViewBag.x = 5;
            // ViewData["x"] = 5;

            #endregion
            #endregion

            //return View();
            return RedirectToAction("index2", "Product");

        }

        public IActionResult index2(){

            // var v1 = ViewBag.x;
            // var v2= ViewData["x"];
            // var v3 = TempData["x"];

            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);

            return View();
        }
    }
}
