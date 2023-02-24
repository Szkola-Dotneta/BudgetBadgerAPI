using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Application.Logic.Expense.Queries;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Handlers
{
    public class DeleteExpenseHandler : IRequestHandler<DeleteExpenseCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;

        public DeleteExpenseHandler(IApplicationDbContext context, ISender mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(DeleteExpenseCommand request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesExpenseExistByIdQuery(request.ExpenseId)))
                throw new EntityNotFoundException(nameof(request.ExpenseId));

            var expense = new Domain.Entities.Expense { Id = request.ExpenseId };
            _context.Expenses.Attach(expense);

            expense.Deleted = true;

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
