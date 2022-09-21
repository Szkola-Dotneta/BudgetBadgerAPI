using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.BudgetChangeEntity
{
    internal class ValueNegativeDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0m };
            yield return new object[] { -0.0001m };
            yield return new object[] { -8569m };
        }
    }
}
