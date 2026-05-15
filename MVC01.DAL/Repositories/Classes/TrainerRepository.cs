using Microsoft.EntityFrameworkCore;
using MVC01.DAL.Models;
using MVC01.DAL.Repositories.Interfaces;
using MVC01.Dbcontexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Repositories.Classes
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly GymDbCotext _context;
        public TrainerRepository(GymDbCotext context)
        {
            _context = context;
        }
        Task ITrainerRepository.AddTrainerAsync(Trainer trainer, CancellationToken cancellationToken)
        {
            _context.Trainers.Add(trainer);
            return _context.SaveChangesAsync(cancellationToken);
        }

        Task ITrainerRepository.DeleteTrainerAsync(Trainer trainer, CancellationToken cancellationToken)
        {
            _context.Trainers.Remove(trainer);
            return _context.SaveChangesAsync(cancellationToken);
        }

        Task<List<Trainer>> ITrainerRepository.GetAllTrainersAsync(bool trackChanges, CancellationToken cancellationToken)
        {
            _context.ChangeTracker.QueryTrackingBehavior = trackChanges ? Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll : Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            return _context.Trainers.ToListAsync(cancellationToken);
        }

        Task<Trainer> ITrainerRepository.GetTrainerByIdAsync(int id, CancellationToken cancellationToken)
        {
            return _context.Trainers.FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
        }

        Task ITrainerRepository.UpdateTrainerAsync(Trainer trainer, CancellationToken cancellationToken)
        {
            _context.Trainers.Update(trainer);
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
