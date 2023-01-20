using BudgetBadgerWebApi.Application.Mappings.Dtos.Expense;
using BudgetBadgerWebApi.Domain.Enums;
using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Commands
{
    public record UpdateExpenseCommand(string Name, decimal Value, DateTime OccurredAt, ExpenseStatusEnum Status, int CategoryId, int ExpenseId) : IRequest<ExpenseDto>;
}
