using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }   
    }
}