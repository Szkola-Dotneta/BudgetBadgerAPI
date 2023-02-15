using System.Security.Claims;

namespace BudgetBadgerWebApi.Api.Jwt
{
    public class Account
    {
        public int Id { get; }
        public int HouseholdId { get; }

        public Account(List<Claim> claims)
        {
            if (claims == null)
                throw new ArgumentNullException(nameof(claims));

            Id = int.Parse(claims.Where(x => x.Type == CustomClaimTypes.Id).Select(x => x.Value).FirstOrDefault());
            HouseholdId = int.Parse(claims.Where(x => x.Type == CustomClaimTypes.Household).Select(x => x.Value).FirstOrDefault());
        }
    }
}
