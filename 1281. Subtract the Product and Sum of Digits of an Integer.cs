public class Solution {
    public int SubtractProductAndSum(int n) {
     char[] num = n.ToString().ToCharArray();
            int product = 1, sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                product *= int.Parse(num[i].ToString());
                sum += int.Parse(num[i].ToString());
            }
            return product - sum;   
    }
}