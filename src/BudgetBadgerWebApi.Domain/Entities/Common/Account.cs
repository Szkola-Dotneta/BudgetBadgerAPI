namespace BudgetBadgerWebApi.Domain.Entities.Common
{
    public class Account : NamedEntity
    {
        public byte[]? Salt { get; set; }
        public byte[]? PasswordHash { get; set; }
    }
}
