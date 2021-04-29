public class Solution {
    public int[] ShortestToChar(string S, char C) {
        List<int> list = new List<int>();
        for(int i = 0; i < S.Length; i++)
        {
            if(S[i].Equals(C)) list.Add(i);
        }
        
        int[] result = new int[S.Length];
        for(int i = 0; i < S.Length; i++)
        {
            result[i] = CalcLowestValue(i, list);
        }
        
        return result;
    }
    
    public int CalcLowestValue(int i, List<int> list)
    {
        int smallest = 10000;
        foreach(int element in list)
        {
            if(Math.Abs(i - element) < smallest) smallest = Math.Abs(i - element);
        }
        
        return smallest;
    }
    
}

/*
Conditions:
1. All characters in string S are lowercase; char C is also lowercase.
2. C, a character in string S, is guaranteed to appear at least once.
    a. If string S is only one character long, then return 0.
3. The return value is an array of integers whose length is the same as that of string S.

PseudoCode:
1. Create a list that contains indices of all instances of char C
2. For each index in string S, calculate the distance between the index and each element in the list.
    a. Create a function that calculates the lowest value in each comparision
    b. Replace the letter in each index with the lowest value



*/