using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface IIncomeRepository
{
    Task<Income> GetAsync(int id);

    Task<Income> GetAsync(string name);

    Task<IEnumerable<Income>> BrowseAsync(string name = "");

    Task AddAsync(Income income);

    Task UpdateAsync(Income income);

    Task DeleteAsync(int id);
}