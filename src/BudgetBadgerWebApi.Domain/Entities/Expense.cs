using BudgetBadgerWebApi.Domain.Entities.Common;
using BudgetBadgerWebApi.Domain.Enums;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Expense : BudgetChangeEntity
    {
        public ExpenseStatusEnum Status { get; set; } = ExpenseStatusEnum.Completed;

        public List<HouseMemberExpense> HouseMemberExpenses { get; set; } = new();
    }
}
