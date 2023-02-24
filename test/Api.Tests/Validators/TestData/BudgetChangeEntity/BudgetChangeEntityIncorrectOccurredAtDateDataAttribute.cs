using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.BudgetChangeEntity
{
    public class BudgetChangeEntityIncorrectOccurredAtDateDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { DateTime.UtcNow.AddYears(-1).AddDays(-1).Date };
            yield return new object[] { DateTime.UtcNow.AddDays(1).Date };
        }
    }
}
