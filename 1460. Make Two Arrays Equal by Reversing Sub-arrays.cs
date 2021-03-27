public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        List<int> list = new List<int>();
        foreach(int element in target)
            list.Add(element);
        foreach(int element in arr)
            list.Remove(element);
        if(list.Count > 0) return false;
        else return true;
    }
}


/*
My understanding is that as long as the arr has the same set of elements as the target array, it should return true.

Strategy:

1. Create a List of the same size as the target array and populate it with every element of the target array.
2. Loop through each element of arr, removing the matching element from the List created in Step 1.
3. If the List has any element remaining, return false; otherwise, return true.

*/
