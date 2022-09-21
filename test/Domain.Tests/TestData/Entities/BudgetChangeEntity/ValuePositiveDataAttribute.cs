using System.Reflection;
using Xunit.Sdk;

namespace Domain.Tests.TestData.Entities.BudgetChangeEntity
{
    internal class ValuePositiveDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0.01m };
            yield return new object[] { 125m };
            yield return new object[] { 10099.99m };
        }
    }
}
