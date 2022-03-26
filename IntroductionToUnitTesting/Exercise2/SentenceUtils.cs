using System.Text;

namespace Exercise2
{
    public static class SentenceUtils
    {
        public static string ToTitleCase(this string str)
        {
            if (str == null || str.Length == 0)
            {
                return str;
            }

            StringBuilder result = new StringBuilder(str);
            result[0] = char.ToUpper(result[0]);
            for (int i = 1; i < result.Length; i++)
            {
                if (char.IsWhiteSpace(result[i - 1]))
                {
                    result[i] = char.ToUpper(str[i]);
                }
                else
                {                    
                    result[i] = char.ToLower(str[i]);
                }

            }

            return result.ToString();
        }
    }
}