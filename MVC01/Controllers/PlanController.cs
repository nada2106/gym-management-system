using MVC01.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC01.Dbcontexts;

namespace MVC01.Controllers
{
    public class PlanController : Controller
    {
        //private readonly GymDbCotext _context;
        private readonly IPlanRepository planRepository;
        public PlanController(IPlanRepository planRepository)
        {
            this.planRepository = planRepository;
        }
        // GET: PlanController
        //index 
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var plans = await planRepository.GetAllPlansAsync(cancellationToken: cancellationToken);
            return View(plans);
        }
        //details
        //GET: PlanController/Details/id
        public async Task<IActionResult> Details(int id, CancellationToken cancellationToken)
        {
            var plan = await planRepository.GetPlanByIdAsync(id, cancellationToken: cancellationToken);
            if (plan == null)
            {
                return NotFound();
            }
            return View(plan);
        }
    }
}
