namespace StringValidatorLibrary
{
    public class LengthEqualTo : IntegerComparisonOperator
    {
        public LengthEqualTo(int reference) : base(reference)
        {
        }

        public override bool IsValid(string value)
        {
            return value.Length == Reference;
        }
    }
}
