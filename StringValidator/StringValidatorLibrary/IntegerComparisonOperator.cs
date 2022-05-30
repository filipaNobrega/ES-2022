namespace StringValidatorLibrary
{
    public abstract class IntegerComparisonOperator : IValidator
    {
        protected int Reference { get; }

        public IntegerComparisonOperator(int reference)
        {
            Reference = reference;
        }

        public abstract bool IsValid(string value);
    }
}
