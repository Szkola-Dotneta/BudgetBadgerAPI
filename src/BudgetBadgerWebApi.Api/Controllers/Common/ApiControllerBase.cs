using BudgetBadgerWebApi.Api.Jwt;
using BudgetBadgerWebApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers.Common
{
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;
        //protected Account Account => new(User.Claims.ToList());
        protected Account Account => new(1, 1);

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
