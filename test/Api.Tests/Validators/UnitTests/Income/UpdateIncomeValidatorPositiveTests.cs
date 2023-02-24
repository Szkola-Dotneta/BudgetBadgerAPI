using Api.Tests.Validators.TestData.BudgetChangeEntity;
using Api.Tests.Validators.TestData.Common;
using BudgetBadgerWebApi.Api.ActionParameters.Income;
using BudgetBadgerWebApi.Api.Validators.Income;
using FluentValidation.TestHelper;

namespace Api.Tests.Validators.UnitTests.Income
{
    [Trait("Unit tests", "Validators")]
    public class UpdateIncomeValidatorPositiveTests : ValidatorTestsBase<UpdateIncomeValidator>
    {
        [Theory]
        [EntityCorrectNameData]
        public void Should_Pass_Validation_For_Name(string name)
        {
            var model = new UpdateIncome { Name = name, Value = 100m, OccurredAt = DateTime.UtcNow.Date, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.Name);
        }

        [Theory]
        [BudgetChangeEntityCorrectValueData]
        public void Should_Pass_Validation_For_Value(decimal value)
        {
            var model = new UpdateIncome { Name = "test", Value = value, OccurredAt = DateTime.UtcNow.Date, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.Value);
        }

        [Theory]
        [BudgetChangeEntityCorrectOccurredAtDateData]
        public void Should_Pass_Validation_For_OccurredAt(DateTime occurredAt)
        {
            var model = new UpdateIncome { Name = "test", Value = 100m, OccurredAt = occurredAt, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.OccurredAt);
        }

        [Theory]
        [EntityCorrectIdData]
        public void Should_Pass_Validation_For_CategoryId(int categoryId)
        {
            var model = new UpdateIncome { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, CategoryId = categoryId };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.CategoryId);
        }
    }
}
