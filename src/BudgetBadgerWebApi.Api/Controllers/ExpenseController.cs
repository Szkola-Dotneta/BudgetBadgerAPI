using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.Controllers.Common;
using BudgetBadgerWebApi.Application.Logic.Expense.Commands;
using BudgetBadgerWebApi.Application.Logic.Expense.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers
{
    [Route("api/houseHolds/{householdId}/expenses")]
    public class ExpenseController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetExpensesAsync(int householdId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var expenses = await Mediator.Send(new GetExpensesQuery(householdId));

            return Ok(expenses);
        }

        [HttpGet("{expenseId}")]
        public async Task<IActionResult> GetExpenseByIdAsync(int householdId, int expenseId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var expense = await Mediator.Send(new GetExpenseForGivenHouseholdByIdQuery(householdId, expenseId));

            return Ok(expense);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpenseAsync([FromBody] CreateExpense command, int householdId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var expense = await Mediator.Send(command.GetCreateExpenseCommand(householdId, Account.Id));

            return Created($"{Request.Host}{Request.Path}/", expense);
        }

        [HttpPut("{expenseId}")]
        public async Task<IActionResult> UpdateExpenseAsync([FromBody] UpdateExpense command, int householdId, int expenseId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var expense = await Mediator.Send(command.GetUpdateExpenseCommand(expenseId));

            return Ok(expense);
        }

        [HttpDelete("{expenseId}")]
        public async Task<IActionResult> DeleteExpenseAsync(int householdId, int expenseId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            await Mediator.Send(new DeleteExpenseCommand(expenseId));

            return NoContent();
        }
    }
}
