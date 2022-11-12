using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface IHouseholdRepository
{
    Task<Household> GetAsync(int id);

    Task<Household> GetAsync(string name);

    Task<IEnumerable<Household>> BrowseAsync(string household = "");

    Task AddAsync(Household household);

    Task UpdateAsync(Household household);

    Task DeleteAsync(int id);
}