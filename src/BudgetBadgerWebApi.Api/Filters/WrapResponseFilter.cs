using BudgetBadgerWebApi.Api.Filters.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BudgetBadgerWebApi.Api.Filters
{
	public class WrapResponseFilter : IAsyncAlwaysRunResultFilter
	{
		public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
		{
			if (context.Result is ObjectResult response)
			{
				var wraper = new ResponseWrapObject();

				switch (response.StatusCode)
				{
					case >= 400:
						wraper.Success = false;
						wraper.Error = response.Value;
						break;

					default:
						wraper.Success = true;
						wraper.Value = response.Value;
						break;
				}

				context.Result = new ObjectResult(wraper) { StatusCode = response.StatusCode };
			}

			await next();
		}
	}
}
