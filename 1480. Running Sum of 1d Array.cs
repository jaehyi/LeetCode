public class Solution {
    public int[] RunningSum(int[] nums) {
        if(nums.Length == 1) return nums;
        for(int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        
        return nums;
    }
}

/*
Conditions
1. Given an array of integers named nums
2. Running sum of an array: runningSum[i] = sum(nums[0] ... nums[i])
      nums:            [1,2,3,4]
      runningSum[0]:   1
      runningSum[1]:   3
      runningSum[]:    [1,3,6,10]
3. nums array will have at least one number and less than or equal to 1000
4. each number in the nums array can be between -1,000,000 and 1,000,000, both inclusive

Return value:  an integer array of running sum

Strategy:
1.  Instead of creating a new integer array, use the array that is passed in as the argument
2.  If the length of the array is 1, then return the array as the return value.
3.  If the length of the array is more than 1, then
    a.  Create a FOR loop that will loop from the second index to the last
    b.  Set the value of the second index to (value at first index + the value at the current index)
    c.  We repeat the step 3b until the last index.
4.  Return the nums array with updated values.


*/