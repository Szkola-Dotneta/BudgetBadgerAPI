using BudgetBadgerWebApi.Domain.Entities;
using Domain.Tests.TestData.Entities.HouseMemberExpense;

namespace Domain.Tests.UnitTests.Entities
{
    [Trait("Unit Tests", "Entities")]

    public class HouseMemberExpenseTests
    {
        [Theory]
        [ContributionInPercentageNegativeData]
        public void ContributionInPercentage_Should_Throw_ArgumentOutOfRangeException_For_Value_Otside_0_To_1_Range(double contributionInPercentageTestValue)
        {
            HouseMemberExpense houseMemberExpense = new();

            Action act = () => houseMemberExpense.ContributionInPercentage = contributionInPercentageTestValue;

            act.Should().ThrowExactly<ArgumentOutOfRangeException>();
        }

        [Theory]
        [ContributionInPercentagePositiveData]
        public void ContributionInPercentage_Should_Set_WithoutException_For_Value_From_0_To_1_Range(double contributionInPercentageTestValue)
        {
            HouseMemberExpense houseMemberExpense = new();

            houseMemberExpense.ContributionInPercentage = contributionInPercentageTestValue;

            houseMemberExpense.ContributionInPercentage.Should().Be(contributionInPercentageTestValue);
        }
    }
}
