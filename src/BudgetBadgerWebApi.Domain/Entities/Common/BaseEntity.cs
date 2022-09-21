namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; } = false;
        public DateOnly CreatedAt { get; set; }
    }
}
