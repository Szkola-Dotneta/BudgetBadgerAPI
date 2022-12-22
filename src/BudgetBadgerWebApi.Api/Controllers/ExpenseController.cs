using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.Controllers.Common;
using BudgetBadgerWebApi.Application.Logic.Expense.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers
{
    [Route("webapi/houseHolds/{householdId}/expenses")]
    public class ExpenseController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetExpensesAsync(int householdId)
        {
            var expenses = await Mediator.Send(new GetExpensesQuery(householdId));

            return Ok(expenses);
        }

        [HttpGet("{expenseId}")]
        public async Task<IActionResult> GetExpenseByIdAsync(int householdId, int expenseId)
        {
            var expense = await Mediator.Send(new GetExpenseForGivenHouseholdByIdQuery(householdId, expenseId));

            return Ok(expense);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpenseAsync([FromBody] CreateExpense command, int householdId)
        {
            var expense = await Mediator.Send(command.GetCreateExpenseCommand(householdId, AccountId));

            return Created($"{Request.Host}{Request.Path}/", expense);
        }

        [HttpPut("{expenseId}")]
        public async Task<IActionResult> UpdateExpenseAsync(int householdId, int expenseId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{expenseId}")]
        public async Task<IActionResult> DeleteExpenseAsync(int householdId, int expenseId)
        {
            throw new NotImplementedException();
        }
    }
}
