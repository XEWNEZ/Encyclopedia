using Microsoft.AspNetCore.Mvc;

namespace Encyclopedia.Website.Controllers
{
	public class BookshelfController : Controller
	{
		#region Kitap Mağzası
		public IActionResult BookShop()
		{
			return View();
		}
		public IActionResult BookDetails()
		{
			return View();
		}
		#endregion
		#region Sepet
		public IActionResult Cart()
		{
			return View();
		}
		public IActionResult Checkout()
		{
			return View();
		}
		#endregion
		#region Yazarlar
		public IActionResult Writers()
		{
			return View();
		}
		public IActionResult WriterDetail()
		{
			return View();
		}
		#endregion
	}
}
