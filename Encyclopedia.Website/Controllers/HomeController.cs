using Encyclopedia.Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Encyclopedia.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #region Anasayfa
        public IActionResult Index()
        {
            return View();
        }
        #endregion
        #region Hakkımızda
        public IActionResult About()
        {
            return View();
        }
        #endregion
        #region İletişim
        public IActionResult Contact()
        {
            return View();
        }
        #endregion
        #region Blog
        public IActionResult BlogList()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
        #endregion
        #region Abonelik
        public IActionResult PricingTable()
        {
            return View();
        }
        #endregion
		#region Servisler
        public IActionResult Services()
        {
            return View();
        }
        #endregion
        #region Referanslar
        public IActionResult References()
        {
            return View();
        }
        #endregion
        #region Gizlilik		
        public IActionResult Privacy()
        {
            return View();
        }
		#endregion
        #region Sıkça Sorulan Sorular
        public IActionResult FAQ()
        {
            return View();
        }
        #endregion
        #region Geçici Hatalar
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
        public IActionResult UnderConstruction()
        {
            return View();
        }
		#endregion
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}