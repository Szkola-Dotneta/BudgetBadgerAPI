namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class BudgetChangeEntity : NamedEntity
    {
        protected decimal _value;
        private DateTime _occurredAt;

        public decimal Value
        {
            get => _value;
            set
            {
                if (value <= 0m)
                    throw new ArgumentException($"{nameof(Value)} of the {GetType().Name} can't be lower than or equal to 0");

                _value = value;
            }
        }

        public DateTime OccurredAt
        {
            get => _occurredAt;
            set => _occurredAt = value.Date;
        }

        public string Category { get; set; } = string.Empty;
        public int HouseholdId { get; set; }
        public Household Household { get; set; } = new();
    }
}
