namespace BudgetBadgerWebApi.Api.Filters.Common
{
    public class ResponseWrapObject
    {
        public bool Success { get; set; }
        public object Value { get; set; } = new();
        public object Error { get; set; } = new();
    }
}
