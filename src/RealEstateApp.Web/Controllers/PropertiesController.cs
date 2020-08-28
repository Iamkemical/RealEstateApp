using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Web.Interfaces;
using RealEstateApp.Web.Models;

namespace RealEstateApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertiesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }   

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Add(PropertyModel model)
        {
            if(!ModelState.IsValid) return View();
            try
            {
                await _propertyService.AddProperty(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}