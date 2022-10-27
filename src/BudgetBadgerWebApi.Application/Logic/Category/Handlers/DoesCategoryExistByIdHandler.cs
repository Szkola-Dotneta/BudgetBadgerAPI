using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Application.Logic.Category.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BudgetBadgerWebApi.Application.Logic.Category.Handlers
{
    public class DoesCategoryExistByIdHandler : IRequestHandler<DoesCategoryExistByIdQuery, bool>
    {
        private readonly IApplicationDbContext _context;

        public DoesCategoryExistByIdHandler(IApplicationDbContext context) => _context = context;

        public async Task<bool> Handle(DoesCategoryExistByIdQuery request, CancellationToken cancellationToken)
            => await _context.Categories.AnyAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);
    }
}
