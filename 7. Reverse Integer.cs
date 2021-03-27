public class Solution {
    public int Reverse(int x) {
            bool IsNegative = x < 0;
            string strX = x.ToString();
            string temp = "";

            for (int i = strX.Length - 1; i >= 0; i--)
            {
                if (strX[i].Equals('-')) break;
                temp += strX[i];
            }

            if (int.TryParse(temp, out x))
            {
                if (IsNegative) return x * -1;
                return x;
            }
            else return 0;

    }
}