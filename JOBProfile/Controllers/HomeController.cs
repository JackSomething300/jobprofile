using JOBProfile.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JOBProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipiesRepository _recipiesRepository;

        public HomeController(IRecipiesRepository recipiesRepository)
        {
            _recipiesRepository = recipiesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet()]
        [Route("/recipies")]
        public IActionResult Recipies()
        {
            return View("~/Pages/Recipies.cshtml");
        }

        [HttpPost]
        [Route("/search/getallrecipies")]
        public async Task<JsonResult> GetAllRecipies()
        {
            var recipies = await _recipiesRepository.GetAllAsync();
            return Json(recipies);
        }

    }
}
