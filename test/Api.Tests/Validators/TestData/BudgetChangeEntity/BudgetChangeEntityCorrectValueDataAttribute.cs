using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.BudgetChangeEntity
{
    public class BudgetChangeEntityCorrectValueDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0.1m };
            yield return new object[] { 120385.95m };
            yield return new object[] { 100000000000m };
        }
    }
}
