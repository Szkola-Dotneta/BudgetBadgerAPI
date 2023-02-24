using BudgetBadgerWebApi.Api.Jwt;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers.Common
{
    public class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;
        protected Account Account => new(User.Claims.ToList());

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
