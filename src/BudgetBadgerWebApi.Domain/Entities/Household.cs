using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Household : NamedEntity
    {
        public decimal CurrentBudget { get; set; }

        public List<HouseMember> HouseMembers { get; set; } = new();
        public List<Income> Incomes { get; set; } = new();
        public List<Expense> Expenses { get; set; } = new();
    }
}
