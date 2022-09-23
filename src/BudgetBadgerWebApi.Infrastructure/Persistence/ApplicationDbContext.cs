using BudgetBadgerWebApi.Application.Common.Interfaces;
using BudgetBadgerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BudgetBadgerWebApi.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<HouseMember> HouseMembers { get; set; }
        public DbSet<Household> Households { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<HouseMemberExpense> HouseMemberExpenses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes()
                    .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
