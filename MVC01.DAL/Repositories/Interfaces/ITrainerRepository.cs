using MVC01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Repositories.Interfaces
{
    internal interface ITrainerRepository
    {
        Task<List<Trainer>> GetAllTrainersAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
        Task<Trainer> GetTrainerByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddTrainerAsync(Trainer trainer, CancellationToken cancellationToken = default);
        Task UpdateTrainerAsync(Trainer trainer, CancellationToken cancellationToken = default);
        Task DeleteTrainerAsync(Trainer trainer, CancellationToken cancellationToken = default);
    }
}
