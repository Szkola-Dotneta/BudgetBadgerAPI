using MediatR;

namespace BudgetBadgerWebApi.Application.Logic.Category.Queries
{
    public record DoesCategoryExistByIdQuery(int Id) : IRequest<bool>;
}
