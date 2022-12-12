using BudgetBadgerWebApi.Api.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers
{
    [Route("webapi/houseHolds/{householdId}/expenses")]
    public class ExpenseController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetExpensesAsync(int householdId)
        {
            throw new NotImplementedException();
        }
    }
}
