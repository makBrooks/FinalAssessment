using Microsoft.AspNetCore.Mvc;

namespace FinalAssessment.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Chess()
        {
            return View();
        }
    }
}
