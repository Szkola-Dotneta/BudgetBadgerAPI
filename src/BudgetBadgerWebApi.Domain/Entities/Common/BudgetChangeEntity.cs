namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class BudgetChangeEntity : NamedEntity
    {
        protected decimal _value;

        public DateOnly OccurredAt { get; set; }
    }
}
