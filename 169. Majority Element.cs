public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = 1;
            }
            else{
                dict[nums[i]]++;
            }
            if(dict[nums[i]] > nums.Length / 2) return nums[i];
        }
        
        return 0;
    }
}

/*

1. The majority element will ALWAYS exist in the array.  The majority element is defined as the element that appears more than n / 2 times.
2. Assumption: There will only ONE majority element in any array given.


Strategy:

1. Use a Dictionary to keep track of occurences of all elements
    Dictionary<int, int> dict = new Dictionar<int, int>();
2. Loop through the array from the left and insert the element and the number of occurences into the Dictionary
    If it's a new element in the dictionary, insert it and initialize the value with 1
    If it's an existing element, increment the value by 1
3. When a key with its value that exceeds n/2 is found, return the key for that value

*/