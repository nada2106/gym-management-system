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
    public class MemberRepository : IMemberRepository
    {
        private readonly GymDbCotext _context;
        public MemberRepository(GymDbCotext context)
        {
            _context = context;
        }
        Task IMemberRepository.AddMemberAsync(Member member, CancellationToken cancellationToken)
        {
            _context.Members.Add(member);
            return _context.SaveChangesAsync(cancellationToken);
        }

        Task IMemberRepository.DeleteMemberAsync(Member member, CancellationToken cancellationToken)
        {
            _context.Members.Remove(member);
            return _context.SaveChangesAsync(cancellationToken);
        }

        Task<List<Member>> IMemberRepository.GetAllMembersAsync(bool trackChanges, CancellationToken cancellationToken)
        {
            _context.ChangeTracker.QueryTrackingBehavior = trackChanges ? Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll : Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            return _context.Members.ToListAsync(cancellationToken);
        }

        Task<Member> IMemberRepository.GetMemberByIdAsync(int id, CancellationToken cancellationToken)
        {
            return _context.Members.FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        Task IMemberRepository.UpdateMemberAsync(Member member, CancellationToken cancellationToken)
        {
            _context.Members.Update(member);
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
