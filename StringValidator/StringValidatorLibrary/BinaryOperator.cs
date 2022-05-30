namespace StringValidatorLibrary
{
    public abstract class BinaryOperator : IValidator
    {
        protected IValidator Left { get; }
        protected IValidator Right { get; }

        protected BinaryOperator(IValidator left, IValidator right)
        {
            Left = left;
            Right = right;
        }

        public abstract bool IsValid(string value);
    }
}
