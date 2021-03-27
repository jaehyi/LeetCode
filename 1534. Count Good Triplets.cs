public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int count = 0;

            int lastIndex = arr.Length - 1;

            for (int i = 0; i <= lastIndex - 2; i++)
            {
                for (int j = i + 1 ; j <= lastIndex - 1; j++)
                {
                    for (int k = j + 1; k <= lastIndex ; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a &&
                                Math.Abs(arr[j] - arr[k]) <= b &&
                                Math.Abs(arr[i] - arr[k]) <= c)
                            count++;
                    }
                }
            }

            return count;
    }
}