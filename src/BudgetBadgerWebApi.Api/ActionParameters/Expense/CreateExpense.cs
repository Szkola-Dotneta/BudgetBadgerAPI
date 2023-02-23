using BudgetBadgerWebApi.Api.ActionParameters.Common;
using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Domain.Enums;

namespace BudgetBadgerWebApi.Api.ActionParameters.Expense
{
    public record CreateExpense : NamedActionParameter
    {
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public ExpenseStatusEnum Status { get; set; }
        public int CategoryId { get; set; }

        public CreateExpenseCommand GetCreateExpenseCommand(int householdId, int houseMemberId)
            => new(Name, Value, OccurredAt, Status, CategoryId, householdId, houseMemberId);
    }
}
