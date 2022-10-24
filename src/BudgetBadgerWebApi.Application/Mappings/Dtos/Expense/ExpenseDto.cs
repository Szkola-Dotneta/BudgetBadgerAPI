using BudgetBadgerWebApi.Application.Mappings.Dtos.Category;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Household;
using BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMemberExpense;

namespace BudgetBadgerWebApi.Application.Mappings.Dtos.Expense
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public CategoryDto Category { get; set; } = new();
        public HouseholdShortDto Household { get; set; } = new();
        public List<HouseMemberExpenseShortDto> HouseMemberExpenses { get; set; } = new();
    }
}
