namespace StringValidatorLibrary
{
    public class LengthIsEven : IValidator
    {
        public bool IsValid(string value)
        {
            return value.Length % 2 == 0;
        }
    }
}
