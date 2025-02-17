using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BMI = model.BMI;
                ViewBag.Result = model.Result;
            }
            return View();
        }
    }
}