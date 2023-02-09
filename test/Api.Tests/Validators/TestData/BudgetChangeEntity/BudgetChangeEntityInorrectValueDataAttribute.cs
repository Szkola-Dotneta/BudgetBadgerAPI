using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.BudgetChangeEntity
{
    public class BudgetChangeEntityInorrectValueDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { -10m };
            yield return new object[] { 0.0m };
        }
    }
}
