namespace StringValidatorLibrary
{
    public class And : BinaryOperator
    {
        public And(IValidator left, IValidator right) : base(left, right)
        {
        }

        public override bool IsValid(string value)
        {
            return Left.IsValid(value) && Right.IsValid(value);
        }
    }
}
