using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Expense : BudgetChangeEntity
    {
        public decimal Value
        {
            get => _value;
            set
            {
                if (value >= 0m)
                    throw new ArgumentException($"{nameof(Value)} of the {GetType().Name} can't be or bigger than or equal to 0");

                _value = value;
            }
        }
    }
}
