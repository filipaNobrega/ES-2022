namespace StringValidatorLibrary
{
    public class LengthIsOdd : IValidator
    {
        public bool IsValid(string value)
        {
            return value.Length % 2 != 0;
        }
    }
}
