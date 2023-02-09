using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.BudgetChangeEntity
{
    public class BudgetChangeEntityCorrectOccurredAtDateDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { DateTime.UtcNow.AddYears(-1).Date };
            yield return new object[] { DateTime.UtcNow.Date };
        }
    }
}
