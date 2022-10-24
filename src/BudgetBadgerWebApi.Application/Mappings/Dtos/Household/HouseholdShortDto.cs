namespace BudgetBadgerWebApi.Application.Mappings.Dtos.Household
{
    public class HouseholdShortDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal CurrentBudget { get; set; }
    }
}
