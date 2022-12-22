namespace BudgetBadgerWebApi.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string propertyName) : base($"Entity with the given {propertyName} could not be found.")
        {
        }
    }
}
