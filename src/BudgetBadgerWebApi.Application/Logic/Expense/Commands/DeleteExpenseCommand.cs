using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Commands
{
    public record DeleteExpenseCommand(int ExpenseId) : IRequest;
}
