using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunClubApp.Data;
using RunClubApp.Interfaces;
using RunClubApp.Models;

namespace RunClubApp.Controllers
{
	public class RaceController : Controller
	{
        private readonly IRaceRepository _raceRepository;

        public RaceController(IRaceRepository raceRepository)
		{
            _raceRepository = raceRepository;
        }

		public async Task<IActionResult> Index()
		{
            IEnumerable<Race> races = await _raceRepository.GetAll();
			return View(races);
		}

        public async Task<IActionResult> Details(int id)
        {
            Race race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }
    }
}
