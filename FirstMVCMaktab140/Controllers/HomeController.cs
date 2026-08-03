using System.Diagnostics;
using FirstMVCMaktab140.Models;
using FirstMVCMaktab140.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCMaktab140.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("Register", "Account"); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Fire-and-forget sample: /Home/SendWelcome?name=Ali
        public IActionResult SendWelcome([FromServices] IBackgroundJobClient jobs, string name = "Ali")
        {
            var jobId = jobs.Enqueue<ReportJobService>(s => s.SendWelcomeEmail(name));
            return Content($"Job {jobId} enqueued for {name}. Check /hangfire -> Succeeded.");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
