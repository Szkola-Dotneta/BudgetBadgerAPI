using BudgetBadgerWebApi.Application.Mappings.Dtos.Category;
using BudgetBadgerWebApi.Application.Mappings.Dtos.Household;
using BudgetBadgerWebApi.Application.Mappings.Dtos.HouseMember;

namespace BudgetBadgerWebApi.Application.Mappings.Dtos.Income
{
    public class IncomeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public CategoryDto Category { get; set; } = new();
        public HouseholdShortDto Household { get; set; } = new();
        public HouseMemberShortDto HouseMember { get; set; } = new();
    }
}
