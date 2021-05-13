public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        
        int left = 0;
        int right = arr.Length - 1;
        int i = (left + right) / 2;
        
        while(true){
            if(arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) break;
            else if(arr[i] > arr[i - 1] && arr[i] < arr[i + 1]) left = i;
            else if(arr[i] < arr[i - 1] && arr[i] > arr[i + 1]) right = i;
            
            i = (left + right) / 2;
        }
        
        return i;
    }
}

/*
Facts/Assumptions:

    1.  3 <= arr.length <= 10000
    2.  0 <= arr[i] <= 1,000,000
    3.  arr is guaranteed to be a mountain array.

Solution 1 (Simple solution):

    1. Find the first element where its next element is less than the element
    2. Compare arr[i] with arr[i+1]; as soon as arr[i + 1] is less than arr[i], return i;


    for(int i = 0; i < arr.Length - 1; i++){
        if(arr[i] > arr[i + 1] ) return i;
    }
        
    return 0;

Solution 2 (Binary Tree Search)

    int left = 0;
    int right = arr.Length - 1;
    int i = (left + right) / 2;
        
    while(true){
        if(arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) break;
        else if(arr[i] > arr[i - 1] && arr[i] < arr[i + 1]) left = i;
        else if(arr[i] < arr[i - 1] && arr[i] > arr[i + 1]) right = i;
            
        i = (left + right) / 2;
    }
        
    return i;

*/
