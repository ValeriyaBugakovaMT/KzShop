using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KzShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public string Index()
        {
            return "Index";
        }

        public string GetAll()
        {
            return "Products :";
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
