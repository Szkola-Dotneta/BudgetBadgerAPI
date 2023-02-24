using Api.Tests.Validators.TestData.BudgetChangeEntity;
using Api.Tests.Validators.TestData.Common;
using BudgetBadgerWebApi.Api.ActionParameters.Income;
using BudgetBadgerWebApi.Api.Validators.Income;
using FluentValidation.TestHelper;

namespace Api.Tests.Validators.UnitTests.Income
{
    [Trait("Unit tests", "Validators")]
    public class CreateIncomeValidatorNegativeTests : ValidatorTestsBase<CreateIncomeValidator>
    {
        [Theory]
        [EntityIncorrectNameData]
        public void Should_Fail_Validation_For_Name(string name)
        {
            var model = new CreateIncome { Name = name, Value = 100m, OccurredAt = DateTime.UtcNow.Date, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Name);
        }

        [Theory]
        [BudgetChangeEntityInorrectValueData]
        public void Should_Fail_Validation_For_Value(decimal value)
        {
            var model = new CreateIncome { Name = "test", Value = value, OccurredAt = DateTime.UtcNow.Date, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Value);
        }

        [Theory]
        [BudgetChangeEntityIncorrectOccurredAtDateData]
        public void Should_Fail_Validation_For_OccurredAt(DateTime occurredAt)
        {
            var model = new CreateIncome { Name = "test", Value = 100m, OccurredAt = occurredAt, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.OccurredAt);
        }

        [Theory]
        [EntityIncorrectIdData]
        public void Should_Fail_Validation_For_CategoryId(int categoryId)
        {
            var model = new CreateIncome { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, CategoryId = categoryId };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.CategoryId);
        }
    }
}
