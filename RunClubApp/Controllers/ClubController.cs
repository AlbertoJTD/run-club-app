using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunClubApp.Data;
using RunClubApp.Interfaces;
using RunClubApp.Models;

namespace RunClubApp.Controllers
{
	public class ClubController : Controller
	{
        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public async Task<IActionResult> Index()
		{
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
			return View(clubs);
		}

        public async Task<IActionResult> Details(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }
	}
}
