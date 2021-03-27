public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sortedHeights = new int[heights.Length];
        heights.CopyTo(sortedHeights,0);
        Array.Sort(sortedHeights);
        int counter = 0;
        for(int i = 0; i < heights.Length; i++){
            if(heights[i] != sortedHeights[i]) counter++;
        }
        return counter;
    }
}