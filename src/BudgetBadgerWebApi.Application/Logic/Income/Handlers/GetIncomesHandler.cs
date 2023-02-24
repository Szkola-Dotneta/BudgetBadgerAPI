using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Household.Queries;
using BudgetBadgerWebApi.Application.Logic.Income.Queries;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class GetIncomesHandler : IRequestHandler<GetIncomesQuery, List<IncomeDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public GetIncomesHandler(IApplicationDbContext context, ISender mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<List<IncomeDto>> Handle(GetIncomesQuery request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesHouseholdExistByIdQuery(request.HouseholdId)) == false)
                throw new EntityNotFoundException(nameof(request.HouseholdId));

            var incomes = await _context.Incomes.Where(x => x.HouseholdId == request.HouseholdId && x.Deleted == false)
                .Include(x => x.Category)
                .Include(x => x.Household)
                .Include(x => x.HouseMember)
                .ToListAsync();

            return _mapper.Map<List<IncomeDto>>(incomes);
        }
    }
}
