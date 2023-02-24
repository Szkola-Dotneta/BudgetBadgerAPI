using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Expense.Queries;
using BudgetBadgerWebApi.Application.Logic.Household.Queries;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Handlers
{
    public class GetExpensesHandler : IRequestHandler<GetExpensesQuery, List<ExpenseDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public GetExpensesHandler(IApplicationDbContext context, ISender mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<List<ExpenseDto>> Handle(GetExpensesQuery request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesHouseholdExistByIdQuery(request.HouseholdId)) == false)
                throw new EntityNotFoundException(nameof(request.HouseholdId));

            var expenses = await _context.Expenses.Where(x => x.HouseholdId == request.HouseholdId && x.Deleted == false)
                .Include(x => x.Category)
                .Include(x => x.Household)
                .Include(x => x.HouseMemberExpenses)
                .ToListAsync();

            return _mapper.Map<List<ExpenseDto>>(expenses);
        }
    }
}
