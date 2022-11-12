using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface IHouseMemberRepository
{
    Task<HouseMember> GetAsync(int id);

    Task<HouseMember> GetAsync(string name);

    Task<IEnumerable<HouseMember>> BrowseAsync(string name = "");

    Task AddAsync(HouseMember houseMember);

    Task UpdateAsync(HouseMember houseMember);

    Task DeleteAsync(int id);
}