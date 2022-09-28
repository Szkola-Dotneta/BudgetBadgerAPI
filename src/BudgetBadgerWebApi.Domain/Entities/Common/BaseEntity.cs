namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class BaseEntity
    {
        private DateTime _createdAt;

        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value.Date;
        }

        public int Id { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
