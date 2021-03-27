public class Solution {
    public int FindNumbers(int[] nums) {
        int digits = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] >= 10 && nums[i] <=99) || ((nums[i] >= 1000 && nums[i] <= 9999) || nums[i] == 100000))
                {
                    digits++;
                }
            }

            return digits;
    }
}