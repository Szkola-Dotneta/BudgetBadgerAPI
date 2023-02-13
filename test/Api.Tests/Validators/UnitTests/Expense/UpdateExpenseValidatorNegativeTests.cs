using Api.Tests.Validators.TestData.BudgetChangeEntity.Expense;
using Api.Tests.Validators.TestData.BudgetChangeEntity;
using Api.Tests.Validators.TestData.Common;
using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.Validators.Expense;
using BudgetBadgerWebApi.Domain.Enums;
using FluentValidation.TestHelper;

namespace Api.Tests.Validators.UnitTests.Expense
{
    [Trait("Unit tests", "Validators")]
    public class UpdateExpenseValidatorNegativeTests : ValidatorTestsBase<UpdateExpenseValidator>
    {
        [Theory]
        [EntityIncorrectNameData]
        public void Should_Fail_Validation_For_Name(string name)
        {
            var model = new UpdateExpense { Name = name, Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Name);
        }

        [Theory]
        [BudgetChangeEntityInorrectValueData]
        public void Should_Fail_Validation_For_Value(decimal value)
        {
            var model = new UpdateExpense { Name = "test", Value = value, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Value);
        }

        [Theory]
        [BudgetChangeEntityIncorrectOccurredAtDateData]
        public void Should_Fail_Validation_For_OccurredAt(DateTime occurredAt)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = occurredAt, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.OccurredAt);
        }

        [Theory]
        [ExpenseIncorrectStatusData]
        public void Should_Fail_Validation_For_Status(ExpenseStatusEnum status)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = status, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.Status);
        }

        [Theory]
        [EntityIncorrectIdData]
        public void Should_Fail_Validation_For_CategoryId(int categoryId)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = categoryId };
            var result = validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(m => m.CategoryId);
        }
    }
}
