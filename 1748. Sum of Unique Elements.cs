public class Solution {
    public int SumOfUnique(int[] nums) {
        
        int[] count = new int[101];

            for (int i = 0; i < nums.Length; i++)
                count[nums[i]]++;

            int sum = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 1)
                {
                    sum += i;
                }
            }

            return sum;
    }
   
}