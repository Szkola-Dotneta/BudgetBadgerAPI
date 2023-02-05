using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Income.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class DoesIncomeExistByIdHandler : IRequestHandler<DoesIncomeExistByIdQuery, bool>
    {
        private readonly IApplicationDbContext _context;

        public DoesIncomeExistByIdHandler(IApplicationDbContext context) => _context = context;

        public async Task<bool> Handle(DoesIncomeExistByIdQuery request, CancellationToken cancellationToken)
            => await _context.Incomes.AnyAsync(x => x.Id == request.IncomeId && x.Deleted == false, cancellationToken: cancellationToken);
    }
}
