using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Handlers
{
    public class CreateExpenseHandler : IRequestHandler<CreateExpenseCommand, ExpenseDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public CreateExpenseHandler(IApplicationDbContext dbContext, ISender mediator, IMapper mapper)
        {
            _context = dbContext;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<ExpenseDto> Handle(CreateExpenseCommand request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesHouseholdExistByIdQuery(request.HouseholdId)) == false)
                throw new EntityNotFoundException(nameof(request.HouseholdId));

            if (await _mediator.Send(new DoesCategoryExistByIdQuery(request.CategoryId)) == false)
                throw new EntityNotFoundException(nameof(request.CategoryId));


        }
    }
}
