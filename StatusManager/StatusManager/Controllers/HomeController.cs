using Microsoft.AspNetCore.Mvc;
using StatusManager.Data;
using StatusManager.Models;
using System.Diagnostics;

namespace StatusManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var items = _db.Tasks.ToList();

            return View(items);
        }

        public IActionResult State1()
        {
            var items = _db.Tasks.Where(x => x.Status == "1").ToList();
            return View(items);
        }

        public IActionResult State2()
        {
            var items = _db.Tasks.Where(x => x.Status == "2").ToList();
            return View(items);
        }

        public IActionResult State3()
        {
            var items = _db.Tasks.Where(x => x.Status == "3").ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskVM vm)
        {
            if (ModelState.IsValid)
            {
                var dt = new TaskData
                {
                    Name = vm.Name,
                    Status = vm.Status,
                };

                _db.Tasks.Add(dt);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vm);
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
