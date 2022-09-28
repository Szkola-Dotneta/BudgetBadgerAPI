using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Income : BudgetChangeEntity
    {
        public int HouseMemberId { get; set; }
        public HouseMember HouseMember { get; set; } = new();
    }
}
