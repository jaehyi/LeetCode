public class Solution {
    public int RepeatedNTimes(int[] A) {
        /* As soon as an element cannot be added to the hashset (which means a duplicate exists), return that element  */
        
        HashSet<int> hash = new HashSet<int>();
        foreach(int element in A){
            if(!hash.Add(element)) return element;
        }
        return 0;
        
        
        
        /* It returns correct result, but not the most efficient
        
        int n = A.Length / 2;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int element in A)
        {
            if(!dict.ContainsKey(element))
            {
                dict[element] = 1;
            }
            else
            {
                dict[element]++;
                if(dict[element] == n) return element;
            }
        }
        
        return 0;
        */
    }
}

/*
1. Calculate the value of N by dividing the size of a given array by 2, then store it in a variable
2. Create a Dictionary<int, int>; the first will record the elements, the second the number of times each element appears in the array
3. When a new element is added, initialize the value with 1
4. When a repeating element is added, increment the value by 1 and check to see if the value is equal to the variable in #1
    a.  If it's the same, return the key associated with the value

*/