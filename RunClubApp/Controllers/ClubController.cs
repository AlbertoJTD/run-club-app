using Microsoft.AspNetCore.Mvc;

namespace RunClubApp.Controllers
{
	public class ClubController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
