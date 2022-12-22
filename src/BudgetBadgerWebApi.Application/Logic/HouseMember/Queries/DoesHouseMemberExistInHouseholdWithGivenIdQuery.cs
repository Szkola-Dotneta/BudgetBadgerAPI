using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.HouseMember.Queries
{
    public record DoesHouseMemberExistInHouseholdWithGivenIdQuery(int HouseMemberId, int HouseholdId) : IRequest<bool>;
}
