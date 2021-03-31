public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] nums2 = new int[nums.Length];
        nums.CopyTo(nums2,0);
        int indexNums;
        for(int i = 0; i < nums2.Length; i++){
            indexNums = (i + k) % nums2.Length;
            nums[indexNums] = nums2[i];
        }
    }
}