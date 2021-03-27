public class Solution {
       public int[] SmallerNumbersThanCurrent(int[] nums){
        
            int[] outputArray = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
            int numOfSmallerElements = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;
                if (nums[i] > nums[j]) numOfSmallerElements++;
            }

            outputArray[i] = numOfSmallerElements;
        }

        return outputArray;
    }
}