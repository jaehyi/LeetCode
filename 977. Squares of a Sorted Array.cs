public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] temp = new int[nums.Length];
        int left = 0, right = nums.Length - 1;
        for(int i = temp.Length - 1; i >= 0; i--){
            if(Math.Abs(nums[left]) <= Math.Abs(nums[right])){
                temp[i] = nums[right] * nums[right];
                right--;
            }
            else{
                temp[i] = nums[left] * nums[left];
                left++;
            }
        }
        return temp;
    }
}

/*
    This is an alternate way

      for(int i = 0; i < nums.Length; i++){
            nums[i] *= nums[i];
        }
        
        Array.Sort(nums);
        return nums;


*/