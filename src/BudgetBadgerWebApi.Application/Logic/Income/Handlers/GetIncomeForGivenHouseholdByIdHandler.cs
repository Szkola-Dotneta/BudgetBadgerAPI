using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Household.Queries;
using BudgetBadgerWebApi.Application.Logic.Income.Queries;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class GetIncomeForGivenHouseholdByIdHandler : IRequestHandler<GetIncomeForGivenHouseholdByIdQuery, IncomeDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public GetIncomeForGivenHouseholdByIdHandler(IApplicationDbContext context, ISender mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IncomeDto> Handle(GetIncomeForGivenHouseholdByIdQuery request, CancellationToken cancellationToken)
        {
            if (await _mediator.Send(new DoesHouseholdExistByIdQuery(request.HouseholdId)) == false)
                throw new EntityNotFoundException(nameof(request.HouseholdId));

            var income = await _context.Incomes.Where(x => x.HouseholdId == request.HouseholdId && x.Id == request.IncomeId && x.Deleted == false)
                .Include(x => x.Category)
                .Include(x => x.Household)
                .Include(x => x.HouseMember)
                .FirstOrDefaultAsync();

            if (income == null)
                throw new EntityNotFoundException(nameof(request.IncomeId));

            return _mapper.Map<IncomeDto>(income);
        }
    }
}
