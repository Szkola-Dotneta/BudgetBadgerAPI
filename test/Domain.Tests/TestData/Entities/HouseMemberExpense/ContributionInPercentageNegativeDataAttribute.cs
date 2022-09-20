using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.HouseMemberExpense
{
    internal class ContributionInPercentageNegativeDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { -0.001d };
            yield return new object[] { 0d };
            yield return new object[] { 1.001d };
        }
    }
}
