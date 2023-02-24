using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.HouseMember.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.HouseMember.Handlers
{
    public class DoesHouseMemberExistInHouseholdWithGivenIdHandler : IRequestHandler<DoesHouseMemberExistInHouseholdWithGivenIdQuery, bool>
    {
        private readonly IApplicationDbContext _context;

        public DoesHouseMemberExistInHouseholdWithGivenIdHandler(IApplicationDbContext context) => _context = context;

        public async Task<bool> Handle(DoesHouseMemberExistInHouseholdWithGivenIdQuery request, CancellationToken cancellationToken)
            => await _context.HouseMembers.AnyAsync(x => x.HouseholdId == request.HouseholdId && x.Id == request.HouseMemberId && x.Deleted == false);
    }
}
