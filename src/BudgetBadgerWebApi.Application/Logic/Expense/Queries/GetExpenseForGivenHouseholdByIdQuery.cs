using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Queries
{
    public record GetExpenseForGivenHouseholdByIdQuery(int HouseholdId, int ExpenseId) : IRequest<ExpenseDto>;
}
