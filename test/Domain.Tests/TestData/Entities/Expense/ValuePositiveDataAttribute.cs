using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.Expense
{
    internal class ValuePositiveDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { -0.01m };
            yield return new object[] { -100m };
            yield return new object[] { -899.5m };
        }
    }
}
