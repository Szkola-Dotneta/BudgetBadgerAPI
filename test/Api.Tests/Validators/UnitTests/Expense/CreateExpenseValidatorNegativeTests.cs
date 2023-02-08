using Api.Tests.Validators.TestData.Common;
using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.Validators.Expense;
using BudgetBadgerWebApi.Domain.Enums;
using FluentValidation.TestHelper;

namespace Api.Tests.Validators.UnitTests.Expense
{
    [Trait("Unit tests", "Validators")]
    public class CreateExpenseValidatorNegativeTests : ValidatorTestsBase<CreateExpenseValidator>
    {
        [Theory]
        [EntityIncorrectNameData]
        public void Should_Fail_Validation_For_Name(string name)
        {
            var model = new CreateExpense { Name = name, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Name);
        }
    }
}
