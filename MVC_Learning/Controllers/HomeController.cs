using Microsoft.AspNetCore.Mvc;
using MVC_Learning.Models;

namespace MVC_Learning.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {

            var products = new List<Product> {

            new Product(1,"Iphone",50,1540),
            new Product(2,"Mac",20,2500),
            new Product(3,"Ipad",30,1200)};


            return View(products);
        }
    }
}
