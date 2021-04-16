public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1) return new int[] {-1};
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int max = 0;
            for(int j = i + 1; j < arr.Length; j++)
            {
                if(max < arr[j]) max = arr[j];
            }
            arr[i] = max;
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}

/* This is brute force method

1. If arr.Length is 1, then return array with [-1];
2. Create a For loop with index i (it will run to arr.Length - 1)
    a. Get the maximum element between i + 1 and the last element
    b. replace the element at index i with the maximum element retrieved
3. replace the last element with -1.

*/