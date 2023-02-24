using BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMember;

namespace BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMemberExpense
{
    public class HouseMemberExpenseShortDto
    {
        public int Id { get; set; }
        public double ContributionInPercentage { get; set; }
        public HouseMemberShortDto HouseMember { get; set; } = new();
    }
}
