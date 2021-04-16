public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr); // Sort the array first
        int diff = arr[0] - arr[1]; // Capture the difference of the first two elements
        for(int i = 1; i < arr.Length - 1; i++)
        {
            if(diff != arr[i] - arr[i + 1])
            {
                return false; // Return false as soon as the diff between each consecutive elements is different from the initial diff value
            }
        }
        return true; // Return true if diff remained the same
    }
}