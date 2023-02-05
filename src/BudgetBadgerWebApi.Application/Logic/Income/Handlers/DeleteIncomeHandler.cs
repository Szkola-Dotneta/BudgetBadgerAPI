using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Income.Commands;
using BudgetBadgerWebApi.Application.Logic.Income.Queries;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class DeleteIncomeHandler : IRequestHandler<DeleteIncomeCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;

        public DeleteIncomeHandler(IApplicationDbContext context, ISender mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(DeleteIncomeCommand request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesIncomeExistByIdQuery(request.IncomeId)))
                throw new EntityNotFoundException(nameof(request.IncomeId));

            var income = new Domain.Entities.Income { Id = request.IncomeId };
            _context.Incomes.Attach(income);

            income.Deleted = true;

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
