using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Expense.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Handlers
{
    public class DoesExpenseExistByIdHandler : IRequestHandler<DoesExpenseExistByIdQuery, bool>
    {
        private readonly IApplicationDbContext _context;

        public DoesExpenseExistByIdHandler(IApplicationDbContext context) => _context = context;

        public async Task<bool> Handle(DoesExpenseExistByIdQuery request, CancellationToken cancellationToken)
            => await _context.Expenses.AnyAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);
    }
}
