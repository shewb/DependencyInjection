using DependencyInjectionSKE.Models;
using DependencyInjectionSKE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionSKE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly IMyService _myService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILogger<HomeController> logger,
            ISingletonOperation singletonOperation,
            ITransientOperation transientOperation,
            IScopedOperation scopedOperation,
            IMyService myService)
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _myService = myService;

            _logger = logger;
        }

        public IActionResult Index()
        {
            // ViewBag contains controller-requested services
            ViewBag.Transient = _transientOperation;
            ViewBag.Scoped = _scopedOperation;
            ViewBag.Singleton = _singletonOperation;

            // Operation service has its own requested services
            ViewBag.Service = _myService;



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}