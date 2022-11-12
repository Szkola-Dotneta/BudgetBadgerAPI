using BudgetBadgerWebApi.Domain.Entities;

namespace BudgetBadgerWebApi.Domain.Repositories;

internal interface ICategoryRepository
{
    Task<Category> GetAsync(int id);

    Task<Category> GetAsync(string name);

    Task<IEnumerable<Category>> BrowseAsync(string name = "");

    Task AddAsync(Category category);

    Task UpdateAsync(Category category);

    Task DeleteAsync(int id);
}