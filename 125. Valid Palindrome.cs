public class Solution {
    public bool IsPalindrome(string s) {
          string result = "";

            foreach (char character in s)
            {
                if ((character >= 48 && character <= 57) || (character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                {
                    result += character;
                }
            }

            result = result.ToLower();
            if (s.Length == 0) return true;

            for (int i = 0; i < result.Length / 2; i++)
                if (result[i] != result[result.Length - 1 - i]) return false;

            return true;
    }
}