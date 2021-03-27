public class Solution {
    public int[] FinalPrices(int[] prices) {
        for(int i = 0; i < prices.Length; i++){
            for(int j = i + 1; j < prices.Length; j++){
                if(prices[j] <= prices[i]){
                    prices[i] -= prices[j];
                    break;
                }
            }
        }
        return prices;
    }
}

/*

Stategy:

1. Loop through each element in prices array
2. We can use the same array, prices, since we are only traversing one way.
3. This will require an inner loop. For each element, look to see if any discount can be applied by looking at j (i + 1 to length - 1) and see if the element at j is less than or equal to the element at i.  If found, substract the amount at index j from that at index i; if not, leave the element at index i unchanged.
4. Return the array once the outer loop is complete.

*/