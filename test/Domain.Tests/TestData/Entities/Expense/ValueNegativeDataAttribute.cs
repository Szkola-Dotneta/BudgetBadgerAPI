using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.Expense
{
    internal class ValueNegativeDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0m };
            yield return new object[] { 0.01m };
            yield return new object[] { 509.99m };
        }
    }
}
