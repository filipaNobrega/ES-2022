namespace StringValidatorLibrary
{
    public class Or : BinaryOperator
    {
        public Or(IValidator left, IValidator right) : base(left, right)
        {
        }

        public override bool IsValid(string value)
        {
            return Left.IsValid(value) || Right.IsValid(value);
        }
    }
}
