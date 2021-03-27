public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in arr){
            if(dict.ContainsKey(num)) dict[num]++;
            else dict[num] = 1;
        }
        
        for(int i = 0; i < dict.Count; i++){
            for(int j = i + 1; j < dict.Count; j++){
                if(dict.Values.ElementAt(i) == dict.Values.ElementAt(j)) return false;
            }
        }
        
        return true;
    }
}