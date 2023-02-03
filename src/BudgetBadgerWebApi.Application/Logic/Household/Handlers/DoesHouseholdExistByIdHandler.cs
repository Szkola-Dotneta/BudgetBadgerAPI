using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Household.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Household.Handlers
{
    public class DoesHouseholdExistByIdHandler : IRequestHandler<DoesHouseholdExistByIdQuery, bool>
    {
        private readonly IApplicationDbContext _context;

        public DoesHouseholdExistByIdHandler(IApplicationDbContext context) => _context = context;

        public async Task<bool> Handle(DoesHouseholdExistByIdQuery request, CancellationToken cancellationToken)
            => await _context.Households.AnyAsync(x => x.Id == request.Id && x.Deleted == false, cancellationToken: cancellationToken);
    }
}
