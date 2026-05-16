using Microsoft.EntityFrameworkCore;
using MVC01.DAL.Repositories.Interfaces;
using MVC01.Dbcontexts;
using MVC01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymDbCotext _context;
        public PlanRepository(GymDbCotext context)
        {
            this._context = context;
        }
        public Task AddPlanAsync(Plan plan, CancellationToken cancellationToken = default)
        {
            this._context.Plans.Add(plan);
            return this._context.SaveChangesAsync(cancellationToken);
        }

        public Task DeletePlanAsync(Plan plan, CancellationToken cancellationToken = default)
        {
            plan.IsActive = false;
            this._context.Plans.Update(plan);
            return this._context.SaveChangesAsync(cancellationToken);
        }

        public Task<List<Plan>> GetAllPlansAsync(bool trackChanges = false, CancellationToken cancellationToken = default)
        {
            this._context.ChangeTracker.QueryTrackingBehavior = trackChanges ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;
            return this._context.Plans.Where(p => p.IsActive).ToListAsync(cancellationToken);
        }

        public async Task<Plan> GetPlanByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var plan = await this._context.Plans.FirstOrDefaultAsync(p => p.Id == id && p.IsActive, cancellationToken);
            if (plan == null)
            {
                throw new InvalidOperationException($"Plan with Id {id} not found or is inactive.");
            }
            return plan;
        }

        public Task UpdatePlanAsync(Plan plan, CancellationToken cancellationToken = default)
        {
            this._context.Plans.Update(plan);
            return this._context.SaveChangesAsync(cancellationToken);
        }
    }
}
