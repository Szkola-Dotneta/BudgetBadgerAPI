using BudgetBadgerWebApi.Api.ActionParameters.Common;
using BudgetBadgerWebApi.Application.Logic.Income.Commands;

namespace BudgetBadgerWebApi.Api.ActionParameters.Income
{
    public record UpdateIncome : NamedActionParameter
    {
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public int CategoryId { get; set; }

        public UpdateIncomeCommand GetUpdateIncomeCommand(int incomeId)
            => new(Name, Value, OccurredAt, CategoryId, incomeId);
    }
}
