using BudgetBadgerWebApi.Domain.Entities;
using Domain.Tests.TestData.Entities.Expense;
using FluentAssertions;

namespace Domain.Tests.UnitTests.Entities
{
    [Trait("Unit Tests", "Entities")]
    public class ExpenseTests
    {
        [Theory]
        [ValueNegativeData]
        public void ValueProperty_Should_Throw_ArgumentException_For_Value_GreaterThanOrEqualTo_Zero(decimal testValue)
        {
            Expense expense = new();

            Action act = () => expense.Value = testValue;

            act.Should().ThrowExactly<ArgumentException>();
        }

        [Theory]
        [ValuePositiveData]
        public void ValueProperty_Should_Set_WithoutException_For_Value_LowerThan_0(decimal testValue)
        {
            Expense expense = new();

            expense.Value = testValue;

            expense.Value.Should().Be(testValue);
        }
    }
}
