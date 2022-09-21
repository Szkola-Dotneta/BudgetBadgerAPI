using BudgetBadgerWebApi.Domain.Entities.Common;
using Domain.Tests.TestData.Entities.BudgetChangeEntity;
using FluentAssertions;

namespace Domain.Tests.UnitTests.Entities
{
    [Trait("Unit Tests", "Entities")]
    public class BudgetChangeEntityTests
    {
        [Theory]
        [ValueNegativeData]
        public void ValueProperty_Should_Throw_ArgumentException_For_Value_LowerThanOrEqualTo_Zero(decimal testValue)
        {
            BudgetChangeEntity budgetChangeEntity = new();

            Action act = () => budgetChangeEntity.Value = testValue;

            act.Should().ThrowExactly<ArgumentException>();
        }

        [Theory]
        [ValuePositiveData]
        public void ValueProperty_Should_Set_WithoutException_For_Value_GreaterThan_0(decimal testValue)
        {
            BudgetChangeEntity budgetChangeEntity = new();

            budgetChangeEntity.Value = testValue;

            budgetChangeEntity.Value.Should().Be(testValue);
        }
    }
}
