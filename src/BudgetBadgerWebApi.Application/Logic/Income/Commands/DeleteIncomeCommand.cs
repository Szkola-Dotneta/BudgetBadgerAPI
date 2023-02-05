using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Commands
{
    public record DeleteIncomeCommand(int IncomeId) : IRequest;
}
