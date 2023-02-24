using BudgetBadgerWebApi.Api.Filters.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BudgetBadgerWebApi.Api.Filters
{
    public class WrapResponseFilter : IAsyncAlwaysRunResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (!(context.Result is FileStreamResult))
            {
                var wraper = new ResponseWrapObject();
                var result = (ObjectResult)context.Result;

                switch (context.HttpContext.Response.StatusCode)
                {
                    case >= 400:
                        wraper.Success = false;
                        wraper.Error = result.Value;
                        break;

                    default:
                        wraper.Success = true;
                        wraper.Value = result.Value;
                        break;
                }

                context.Result = new ObjectResult(wraper);
            }

            await next();
        }
    }
}
