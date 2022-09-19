using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class HouseMember : NamedEntity
    {
        public byte[]? Salt { get; set; }
        public byte[]? PasswordHash { get; set; }
        public int HouseholdId { get; set; }
        public Household Household { get; set; } = new();
    }
}
