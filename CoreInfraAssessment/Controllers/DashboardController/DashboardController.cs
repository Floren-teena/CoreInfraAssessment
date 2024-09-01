using Microsoft.AspNetCore.Mvc;

namespace CoreInfraAssessment.Controllers.DashboardController
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
