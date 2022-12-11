namespace BudgetBadgerWebApi.Application.Common.Exceptions
{
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException(string entityName) : base($"Entity '{entityName}' already exists.")
        {
        }
    }
}
