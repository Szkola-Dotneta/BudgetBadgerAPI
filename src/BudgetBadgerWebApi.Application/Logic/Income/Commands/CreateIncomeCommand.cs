using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Commands
{
    public record CreateIncomeCommand(string Name, decimal Value, DateTime OccurredAt, int CategoryId, int HouseholdId, int HouseMemberId) : IRequest<IncomeDto>;
}
