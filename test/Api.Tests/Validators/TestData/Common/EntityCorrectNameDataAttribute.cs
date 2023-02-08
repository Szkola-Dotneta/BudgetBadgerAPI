using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.Common
{
    public class EntityCorrectNameDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { "ab" };
            yield return new object[] { "test name of the entity" };
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse tincidunt aliquet pretium. Vivamus id nisi neque. Suspendisse dapibus purus ante, eu aliquet sapien suscipit nec. Vestibulum tellus" };
        }
    }
}
