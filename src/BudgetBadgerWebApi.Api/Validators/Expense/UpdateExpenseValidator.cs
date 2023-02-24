using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using FluentValidation;

namespace BudgetBadgerWebApi.Api.Validators.Expense
{
    public class UpdateExpenseValidator : AbstractValidator<UpdateExpense>
    {
        public UpdateExpenseValidator()
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

            RuleFor(x => x.Status)
                .NotNull()
                .IsInEnum();

            RuleFor(x => x.CategoryId)
                .NotNull()
                .GreaterThanOrEqualTo(1);
        }
    }
}
