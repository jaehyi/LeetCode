public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
            if (x > 0 && x < 10) return true;

            string xString = x.ToString();
            bool result = true;

            for (int i = xString.Length, b = 0, e = xString.Length - 1; i > 1;)
            {
                if (xString[b++] != xString[e--])
                {
                    result = false;
                    return result;
                }
                i -= 2;
            }
            return result;
    }
}