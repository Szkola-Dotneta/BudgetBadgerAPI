using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Handlers
{
    public class UpdateExpenseHandler : IRequestHandler<UpdateExpenseCommand, ExpenseDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public UpdateExpenseHandler(IApplicationDbContext context, ISender mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<ExpenseDto> Handle(UpdateExpenseCommand request, CancellationToken cancellationToken)
        {
            var expense = await _context.Expenses.SingleOrDefaultAsync(x => x.Id == request.ExpenseId);

            if (expense == null)
                throw new EntityNotFoundException(nameof(request.ExpenseId));

            expense.Update(request.Name, request.Value, request.Status, request.OccurredAt, request.CategoryId);

            _context.Expenses.Update(expense);
            await _context.SaveChangesAsync();

            return _mapper.Map<ExpenseDto>(expense);
        }
    }
}
