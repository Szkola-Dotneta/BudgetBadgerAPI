using AutoMapper;
using BudgetBadgerWebApi.Application.Common.Exceptions;
using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Income.Commands;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class UpdateIncomeHandler : IRequestHandler<UpdateIncomeCommand, IncomeDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateIncomeHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IncomeDto> Handle(UpdateIncomeCommand request, CancellationToken cancellationToken)
        {
            var income = await _context.Incomes.SingleOrDefaultAsync(x => x.Id == request.IncomeId);

            if (income == null)
                throw new EntityNotFoundException(nameof(request.IncomeId));

            income.Update(request.Name, request.Value, request.OccurredAt, request.CategoryId);

            _context.Incomes.Update(income);
            await _context.SaveChangesAsync();

            return _mapper.Map<IncomeDto>(income);
        }
    }
}
