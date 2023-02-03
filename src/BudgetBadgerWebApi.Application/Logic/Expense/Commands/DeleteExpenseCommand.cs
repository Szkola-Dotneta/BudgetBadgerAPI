using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Commands
{
    public record DeleteExpenseCommand(int Id) : IRequest;
}
