using BudgetBadgerWebApi.Domain.Entities.Common;

namespace BudgetBadgerWebApi.Domain.Entities
{
    public class HouseMemberExpense : BaseEntity
    {
        private double _contributionInPercentage;

        public double ContributionInPercentage
        {
            get => _contributionInPercentage;
            set
            {
                if (value <= 0 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(ContributionInPercentage), $"{ContributionInPercentage} must have a value in range from 0 (exclusive) to 1 (inclusive).");

                _contributionInPercentage = value;
            }
        }

        public int ExpenseId { get; set; }
        public int HouseMemberId { get; set; }
        public Expense Expense { get; set; } = new();
        public HouseMember HouseMember { get; set; } = new();
    }
}
