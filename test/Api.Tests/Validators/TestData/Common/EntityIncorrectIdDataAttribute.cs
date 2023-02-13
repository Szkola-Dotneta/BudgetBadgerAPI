using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.Common
{
    public class EntityIncorrectIdDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0 };
            yield return new object[] { -9424 };
        }
    }
}
