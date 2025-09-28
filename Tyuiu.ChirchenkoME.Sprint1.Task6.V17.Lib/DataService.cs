using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChirchenkoME.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;        
            string cleanedString = new string(value.Where(c => !char.IsWhiteSpace(c))
                                                  .Select(char.ToLower)
                                                  .ToArray());  
            for (int i = 0; i < cleanedString.Length / 2; i++)
            {
                if (cleanedString[i] != cleanedString[cleanedString.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
