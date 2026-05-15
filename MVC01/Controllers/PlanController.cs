using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC01.Dbcontexts;

namespace MVC01.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbCotext _context;
        public PlanController()
        {
            _context = new GymDbCotext();
        }
        // GET: PlanController
        //index 
        public async Task<IActionResult> Index()
        {
            var plans = await _context.Plans.ToListAsync();
            return View(plans);
        }
        //details
        //GET: PlanController/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var plan = await _context.Plans.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            return View(plan);
        }
    }
}
