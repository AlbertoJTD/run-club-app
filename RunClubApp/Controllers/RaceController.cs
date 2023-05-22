using Microsoft.AspNetCore.Mvc;

namespace RunClubApp.Controllers
{
	public class RaceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
