using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface IHouseMemberExpenseRepository
{
    Task<HouseMemberExpense> GetAsync(int id);

    Task<HouseMemberExpense> GetAsync(string name);

    Task<IEnumerable<HouseMemberExpense>> BrowseAsync(string name = "");

    Task AddAsync(HouseMemberExpense houseMemberExpense);

    Task UpdateAsync(HouseMemberExpense houseMemberExpense);

    Task DeleteAsync(int id);
}