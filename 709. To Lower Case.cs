public class Solution {
    public string ToLowerCase(string str) {
            string result = "";

            foreach (var letter in str)
            {
                if (letter >= 65 && letter <= 96)
                    result += (char)(letter + 32);
                else
                    result += (char)letter;
            }

            return result;
    }
}