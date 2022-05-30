namespace StringValidatorLibrary
{
    public class LengthLesserThan : IntegerComparisonOperator
    {
        public LengthLesserThan(int reference) : base(reference)
        {
        }

        public override bool IsValid(string value)
        {
            return value.Length < Reference;
        }
    }
}
