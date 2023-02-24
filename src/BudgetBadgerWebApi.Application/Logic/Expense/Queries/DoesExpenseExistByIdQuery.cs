using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Expense.Queries
{
    public record DoesExpenseExistByIdQuery(int Id) : IRequest<bool>;
}
