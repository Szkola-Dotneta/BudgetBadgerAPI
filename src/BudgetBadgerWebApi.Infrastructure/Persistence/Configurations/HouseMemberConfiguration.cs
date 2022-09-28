using BudgetBadgerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetBadgerWebApi.Infrastructure.Persistence.Configurations
{
    public class HouseMemberConfiguration : IEntityTypeConfiguration<HouseMember>
    {
        public void Configure(EntityTypeBuilder<HouseMember> builder)
        {
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired();

            builder.HasMany(x => x.HouseMemberExpenses)
                .WithOne(y => y.HouseMember)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
