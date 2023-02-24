using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Commands
{
    public record UpdateIncomeCommand(string Name, decimal Value, DateTime OccurredAt, int CategoryId, int IncomeId) : IRequest<IncomeDto>;
}
