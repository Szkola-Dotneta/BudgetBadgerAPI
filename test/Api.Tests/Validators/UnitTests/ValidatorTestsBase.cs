namespace Api.Tests.Validators.UnitTests
{
    public class ValidatorTestsBase<TValidator> : IDisposable
    {
        protected TValidator validator;
        public ValidatorTestsBase() => validator = Activator.CreateInstance<TValidator>();

        public void Dispose() => validator = default;
    }
}
