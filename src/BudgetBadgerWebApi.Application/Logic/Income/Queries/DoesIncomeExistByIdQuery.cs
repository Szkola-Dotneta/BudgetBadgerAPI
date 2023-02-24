using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Income.Queries
{
    public record DoesIncomeExistByIdQuery(int IncomeId) : IRequest<bool>;
}
