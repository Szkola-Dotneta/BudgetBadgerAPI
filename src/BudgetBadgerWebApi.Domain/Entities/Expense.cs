using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Expense : BudgetChangeEntity
    {
        public List<HouseMemberExpense> HouseMemberExpenses { get; set; } = new();
    }
}
