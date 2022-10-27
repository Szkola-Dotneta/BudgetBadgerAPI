namespace BudgetBadgerWebApi.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string propertyName) : base($"Entity with the given {propertyName.ToLower()} could not be found.")
        {
        }
    }
}
