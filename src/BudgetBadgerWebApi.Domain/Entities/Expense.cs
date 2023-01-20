using BudgetBadgerWebApi.Domain.Entities.Common;
using BudgetBadgerWebApi.Domain.Enums;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Expense : BudgetChangeEntity
    {
        public ExpenseStatusEnum Status { get; set; } = ExpenseStatusEnum.Completed;

        public List<HouseMemberExpense> HouseMemberExpenses { get; set; } = new();

        public void Update(string name, decimal value, ExpenseStatusEnum status, DateTime occurredAt, int categoryId)
        {
            base.Update(name, value, occurredAt, categoryId);

            Status = status;
        }
    }
}
