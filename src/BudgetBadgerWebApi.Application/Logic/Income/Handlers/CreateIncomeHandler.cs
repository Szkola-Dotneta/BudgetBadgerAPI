using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Category.Queries;
using BudgetBadgerWebApi.Application.Logic.Household.Queries;
using BudgetBadgerWebApi.Application.Logic.Income.Commands;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class CreateIncomeHandler : IRequestHandler<CreateIncomeCommand, IncomeDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public CreateIncomeHandler(IApplicationDbContext context, ISender mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IncomeDto> Handle(CreateIncomeCommand request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesHouseholdExistByIdQuery(request.HouseholdId)) == false)
                throw new EntityNotFoundException(nameof(request.HouseholdId));

            if (await _mediator.Send(new DoesCategoryExistByIdQuery(request.CategoryId)) == false)
                throw new EntityNotFoundException(nameof(request.CategoryId));

            var income = new Domain.Entities.Income
            {
                Name = request.Name,
                Value = request.Value,
                OccurredAt = request.OccurredAt,
                CategoryId = request.CategoryId,
                HouseholdId = request.HouseholdId,
                HouseMemberId = request.HouseMemberId
            };

            await _context.Incomes.AddAsync(income);
            await _context.SaveChangesAsync();

            return _mapper.Map<IncomeDto>(income);
        }
    }
}
