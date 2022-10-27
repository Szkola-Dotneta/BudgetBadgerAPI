using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Household.Queries
{
    public record DoesHouseholdExistByIdQuery(int Id) : IRequest<bool>;
}
