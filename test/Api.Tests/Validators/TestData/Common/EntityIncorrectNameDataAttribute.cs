using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.Common
{
    public class EntityIncorrectNameDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { null };
            yield return new object[] { string.Empty };
            yield return new object[] { "a" };
            yield return new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et orci lectus. Fusce dapibus a dui id sodales. Phasellus tincidunt convallis nunc placerat imperdiet. Nam magna elit, feugiat sed morbi" };
        }
    }
}
