using System.Diagnostics;
using LocalitiesManager.Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocalitiesManager.Frontend.Controllers.General;

[Route("dashboard")]
public class DashboardController : Controller
{
    public DashboardController()
    {
    }

    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}