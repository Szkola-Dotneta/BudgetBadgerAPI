using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Queries
{
    public record GetIncomesQuery(int HouseholdId) : IRequest<List<IncomeDto>>;
}
