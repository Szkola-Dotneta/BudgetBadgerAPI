using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBadgerWebApi.Api.Controllers.Common
{
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
