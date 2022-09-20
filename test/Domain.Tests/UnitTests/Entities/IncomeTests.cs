using BudgetBadgerWebApi.Domain.Entities;
using Domain.Tests.TestData.Entities.Income;
using FluentAssertions;

namespace Domain.Tests.UnitTests.Entities
{
    [Trait("Unit Tests", "Entities")]
    public class IncomeTests
    {
        [Theory]
        [ValueNegativeData]
        public void ValueProperty_Should_Throw_ArgumentException_For_Value_LowerThanOrEqualTo_Zero(decimal testValue)
        {
            Income income = new();

            Action act = () => income.Value = testValue;

            act.Should().ThrowExactly<ArgumentException>();
        }

        [Theory]
        [ValuePositiveData]
        public void ValueProperty_Should_Set_WithoutException_For_Value_GreaterThan_0(decimal testValue)
        {
            Income income = new();

            income.Value = testValue;

            income.Value.Should().Be(testValue);
        }
    }
}
