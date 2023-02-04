using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.ActionParameters.Income;
using BudgetBadgerWebApi.Api.Controllers.Common;
using BudgetBadgerWebApi.Application.Logic.Income.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers
{
    [Route("api/houseHolds/{householdId}/incomes")]
    public class IncomeController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetIncomesAsync(int householdId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var incomes = await Mediator.Send(new GetIncomesQuery(householdId));

            return Ok(incomes);
        }

        [HttpGet("{incomeId}")]
        public async Task<IActionResult> GetIncomeByIdAsync(int householdId, int incomeId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var income = await Mediator.Send(new GetIncomeForGivenHouseholdByIdQuery(householdId, incomeId));

            return Ok(income);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncomeAsync([FromBody] CreateIncome command, int householdId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var income = await Mediator.Send(command.GetCreateIncomeCommand(householdId, Account.Id));

            return Created($"{Request.Host}{Request.Path}/", income);
        }

        [HttpPut("{incomeId}")]
        public async Task<IActionResult> UpdateIncomeAsync([FromBody] UpdateIncome command, int householdId, int incomeId)
        {
            if (householdId != Account.HouseholdId)
                return Forbid();

            var income = await Mediator.Send(command.GetUpdateIncomeCommand(incomeId));

            return Ok(income);
        }
    }
}
