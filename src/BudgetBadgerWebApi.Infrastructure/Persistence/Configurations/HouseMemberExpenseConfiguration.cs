using BudgetBadgerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetBadgerWebApi.Infrastructure.Persistence.Configurations
{
    internal class HouseMemberExpenseConfiguration : IEntityTypeConfiguration<HouseMemberExpense>
    {
        public void Configure(EntityTypeBuilder<HouseMemberExpense> builder)
        {
            builder.HasOne(x => x.HouseMember)
                .WithMany(y => y.HouseMemberExpenses)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Expense)
                .WithMany(y => y.HouseMemberExpenses)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
