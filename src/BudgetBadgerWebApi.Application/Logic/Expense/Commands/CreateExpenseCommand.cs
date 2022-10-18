using BudgetBadgerWebApi.Domain.Enums;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Commands
{
    public record CreateExpenseCommand(decimal Value, DateTime OccurredAt, ExpenseStatusEnum Status, int CategoryId, int HouseholdId) : IRequest<ExpenseDto>;
}
