using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Domain.Enums;

namespace BudgetBadgerWebApi.Api.ActionParameters.Expense
{
    public record UpdateExpense
    {
        private string? name;

        public string Name
        {
            get => name;
            set => name = value?.Trim().ToLowerInvariant();
        }
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public ExpenseStatusEnum Status { get; set; }
        public int CategoryId { get; set; }

        public UpdateExpenseCommand GetUpdateExpenseCommand(int expenseId)
            => new(Name, Value, OccurredAt, Status, CategoryId, expenseId);
    }
}
