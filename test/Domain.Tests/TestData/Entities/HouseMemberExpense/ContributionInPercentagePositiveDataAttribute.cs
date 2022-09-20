using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.HouseMemberExpense
{
    internal class ContributionInPercentagePositiveDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0.005d };
            yield return new object[] { 0.45d };
            yield return new object[] { 0.995d };
        }
    }
}
