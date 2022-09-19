using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Income : BudgetChangeEntity
    {
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
    }
}
