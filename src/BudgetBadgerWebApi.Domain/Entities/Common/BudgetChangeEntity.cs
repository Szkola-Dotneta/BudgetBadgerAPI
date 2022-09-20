namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class BudgetChangeEntity : NamedEntity
    {
        protected decimal _value;

        public string Category { get; set; } = string.Empty;
        public DateOnly OccurredAt { get; set; }

        public int HouseholdId { get; set; }
        public Household Household { get; set; } = new();
    }
}
