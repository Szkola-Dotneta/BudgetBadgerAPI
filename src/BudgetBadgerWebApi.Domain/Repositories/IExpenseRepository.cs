using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface IExpenseRepository
{
    Task<Expense> GetAsync(int id);

    Task<Expense> GetAsync(string name);

    Task<IEnumerable<Expense>> BrowseAsync(string name = "");

    Task AddAsync(Expense expense);

    Task UpdateAsync(Expense expense);

    Task DeleteAsync(int id);
}