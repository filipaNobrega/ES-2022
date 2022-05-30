namespace StringValidatorLibrary
{
    public class NonZeroLength : IValidator
    {
        public bool IsValid(string value)
        {
            return value.Length != 0;
        }
    }
}
