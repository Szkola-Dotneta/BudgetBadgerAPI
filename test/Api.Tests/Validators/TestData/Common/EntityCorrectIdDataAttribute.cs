using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.Common
{
    public class EntityCorrectIdDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1 };
            yield return new object[] { 7894 };
        }
    }
}
