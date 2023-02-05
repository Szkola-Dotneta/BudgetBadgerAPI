using BudgetBadgerWebApi.Domain.Entities.Common;
using BudgetBadgerWebApi.Domain.Enums;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class Income : BudgetChangeEntity
    {
        public int HouseMemberId { get; set; }
        public HouseMember HouseMember { get; set; } = new();

        public new void Update(string name, decimal value, DateTime occurredAt, int categoryId) => base.Update(name, value, occurredAt, categoryId);
    }
}
