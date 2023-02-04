using BudgetBadgerWebApi.Application.Logic.Income.Commands;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Handlers
{
    public class UpdateIncomeHandler : IRequestHandler<UpdateIncomeCommand, IncomeDto>
    {
        public Task<IncomeDto> Handle(UpdateIncomeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
