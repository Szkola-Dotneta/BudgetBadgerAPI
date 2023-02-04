using BudgetBadgerWebApi.Application.Mappings.Dtos.Income;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Queries
{
    public record GetIncomeForGivenHouseholdByIdQuery(int HouseholdId, int IncomeId) : IRequest<IncomeDto>;
}
