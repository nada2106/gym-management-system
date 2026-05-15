using MVC01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        Task<List<Plan>> GetAllPlansAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
        Task<Plan> GetPlanByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddPlanAsync(Plan plan, CancellationToken cancellationToken = default);
        Task UpdatePlanAsync(Plan plan, CancellationToken cancellationToken = default);
        Task DeletePlanAsync(Plan plan, CancellationToken cancellationToken = default);
    }
}
