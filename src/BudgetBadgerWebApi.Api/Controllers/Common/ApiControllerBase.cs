using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers.Common
{
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;
        protected int AccountId => User?.Identity?.IsAuthenticated == true ? int.Parse(User.Claims.ToList().First().Value) : 0;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
