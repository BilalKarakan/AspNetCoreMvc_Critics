using Microsoft.AspNetCore.Mvc;

namespace sampleProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            //Product product = new Product();

            //Veri getirildi...

            //ViewResult result = View(); --> İlgili action ismiyle birebir aynı olan viewi tetikleyecek.
            //return result;

            ViewResult result = View(); //--> Belirtilen isimde ki view dosyasını render eder.
            return result;
            //return View();
        }

        /*
        public PartialViewResult GetProducts2()
        {
            PartialViewResult result = PartialView();
            return result;
        }
        */

        /*
        public JsonResult GetProducts3()
        {
            JsonResult result = Json(new Product
            {
                id = 5,
                ProductName = "Laptop",
                Quantity = 15,

            }); ;
            return result;
        }
        */

        /*
        public EmptyResult GetProducts4()
        {
            return new EmptyResult();
        }
        */

        /*
        public ContentResult GetProducts()
        {
            ContentResult result = Content("How are you today?");
            return result;
        }
        */
    }
}
