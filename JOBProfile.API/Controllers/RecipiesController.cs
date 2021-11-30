using JOBProfile.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JOBProfile.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RecipiesController : ControllerBase
    {
        [HttpGet(Name = "GetAllRecipies")]
        public IEnumerable<Recipies> GetAllRecipies()
        {
            //This should be retrieved from _ElasticClient in core
            List<Recipies> recipies = new List<Recipies>();
            recipies.Add(new Recipies() {
                Name = "Butter chicken curry",
                CookingInstructions = "Cook well before serving",
                Description = "Best Curry Ever",
                Ingredients = new List<string> { "Butter", "Chicken", "Cream" }
            });

            return recipies;
        }
    }
}