using MVC01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Repositories.Interfaces
{
    internal interface IMemberRepository
    {
        Task<List<Member>> GetAllMembersAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
        Task<Member> GetMemberByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddMemberAsync(Member member, CancellationToken cancellationToken = default);
        Task UpdateMemberAsync(Member member, CancellationToken cancellationToken = default);
        Task DeleteMemberAsync(Member member, CancellationToken cancellationToken = default);
    }
}
