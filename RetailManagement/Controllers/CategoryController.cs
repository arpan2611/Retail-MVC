using Microsoft.AspNetCore.Mvc;

namespace RetailManagement.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //ex1 on master
        }
    }
}
