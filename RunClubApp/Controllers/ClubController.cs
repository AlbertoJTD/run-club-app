using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using RunClubApp.Data;
=======
>>>>>>> 9e3949a14f13734c6f97bfbb87de466fa2eec73a

namespace RunClubApp.Controllers
{
	public class ClubController : Controller
	{
<<<<<<< HEAD
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
            var clubs = _context.Clubs.ToList();
			return View(clubs);
=======
		public IActionResult Index()
		{
			return View();
>>>>>>> 9e3949a14f13734c6f97bfbb87de466fa2eec73a
		}
	}
}
