namespace StringValidatorLibrary
{
    public abstract class UnaryOperator : IValidator
    {
        public IValidator Validator { get; }

        protected UnaryOperator(IValidator validator)
        {
            Validator = validator;
        }

        public abstract bool IsValid(string value);
    }
}
