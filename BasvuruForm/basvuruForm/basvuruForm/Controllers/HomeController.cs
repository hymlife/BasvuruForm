using basvuruForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using basvuruForm.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace basvuruForm.Controllers
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
        }

        [HttpPost]
        public IActionResult Index(Personal personel)
        {

            



            return View();
        }


        public ViewResult EgitimDurumu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EgitimDurumu(EgitimDurum egitim)
        {
            return View();
        }

        public ViewResult IsTecrubesi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IsTecrubesi(GecmisIsYeriIstihdam gecmisIsYeriIstihdam)
        {
            return View();
        }

        public IActionResult LastPage()
        {
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
