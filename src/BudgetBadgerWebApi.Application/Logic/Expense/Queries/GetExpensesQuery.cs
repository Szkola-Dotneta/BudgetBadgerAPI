using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Queries
{
    public record GetExpensesQuery(int HouseholdId) : IRequest<List<ExpenseDto>>;
}
