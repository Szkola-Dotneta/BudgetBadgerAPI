using BudgetBadgerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetBadgerWebApi.Infrastructure.Persistence.Configurations
{
    public class HouseholdConfiguration : IEntityTypeConfiguration<Household>
    {
        public void Configure(EntityTypeBuilder<Household> builder)
        {
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
