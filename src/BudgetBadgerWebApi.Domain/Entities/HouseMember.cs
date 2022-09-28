using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class HouseMember : Account
    {
        public int HouseholdId { get; set; }
        public Household Household { get; set; } = new();
        public List<HouseMemberExpense> HouseMemberExpenses { get; set; } = new();
    }
}
