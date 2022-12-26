using Microsoft.AspNetCore.Mvc;

namespace Encyclopedia.Website.Controllers
{
	public class UserController : Controller
	{
		#region Kulanıcı Ayarları
		public IActionResult UserSetting()
		{
			return View();
		}
		public IActionResult AddressSetting()
		{
			return View();
		}
		public IActionResult ContactSetting()
		{
			return View();
		}
		#endregion
		#region Kullanıcı Detayları
		public IActionResult UserProfile()
		{
			return View();
		}
		public IActionResult Wishlist()
		{
			return View();
		}
		public IActionResult MyBook()
		{
			return View();
		}
		public IActionResult MyBlogPost()
		{
			return View();
		}
		public IActionResult MyComment()
		{
			return View();
		}
		public IActionResult Enterer()
		{
			return View();
		}
		#endregion
		#region Giriş
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult ForgotPassword()
		{
			return View();
		}
		public IActionResult Logout()
		{
			return View();
		}
		#endregion
	}
}
