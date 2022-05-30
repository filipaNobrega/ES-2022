namespace StringValidatorLibrary
{
    public class Not : UnaryOperator
    {
        public Not(IValidator validator) : base(validator)
        {
        }

        public override bool IsValid(string value)
        {
            return !Validator.IsValid(value);
        }
    }
}
