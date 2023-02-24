using BudgetBadgerWebApi.Api.ActionParameters.Income;
using FluentValidation;

namespace BudgetBadgerWebApi.Api.Validators.Income
{
    public class UpdateIncomeValidator : AbstractValidator<UpdateIncome>
    {
        public UpdateIncomeValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(200);

            RuleFor(x => x.Value)
                .NotNull()
                .GreaterThan(0.0m)
                .LessThanOrEqualTo(100000000000m);

            RuleFor(x => x.OccurredAt)
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.UtcNow.AddYears(-1).Date)
                .LessThanOrEqualTo(DateTime.UtcNow.Date);

            RuleFor(x => x.CategoryId)
                .NotNull()
                .GreaterThanOrEqualTo(1);
        }
    }
}
