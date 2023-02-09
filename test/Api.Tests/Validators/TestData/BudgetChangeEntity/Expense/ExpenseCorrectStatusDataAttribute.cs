using BudgetBadgerWebApi.Domain.Enums;
using System.Reflection;
using Xunit.Sdk;

namespace Api.Tests.Validators.TestData.BudgetChangeEntity.Expense
{
    public class ExpenseCorrectStatusDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { ExpenseStatusEnum.Pending };
            yield return new object[] { ExpenseStatusEnum.NotCompleted };
            yield return new object[] { ExpenseStatusEnum.Completed };
        }
    }
}
