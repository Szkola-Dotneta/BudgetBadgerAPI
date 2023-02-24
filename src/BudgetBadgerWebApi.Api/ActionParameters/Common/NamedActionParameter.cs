namespace BudgetBadgerWebApi.Api.ActionParameters.Common
{
    public record NamedActionParameter
    {
        private string? name;

        public string Name
        {
            get => name;
            set => name = value?.Trim().ToLowerInvariant();
        }
    }
}
