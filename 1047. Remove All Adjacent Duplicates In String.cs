public class Solution {
    public string RemoveDuplicates(string S) {
        if(S.Length == 1) return S;
        StringBuilder sb = new StringBuilder(S);
        int counter;
        do
        {
            counter = 0;
            for(int i = 0; i < sb.Length - 1; i++)
            {
                if(sb[i] == sb[i + 1])
                {
                    sb.Remove(i, 2);
                    counter++;
                } 
            }
        } while (counter > 0);
        
        return sb.ToString();
    }
}

/*
1. If the length of the string S is 1, then return S
2. Create an instance of StringBuilder with the string S
2a. Create a counter variable and set it to 0
3. Create a Do loop that will run until there are no more instances of duplicate elements
    a. Create a For loop comparing element at i to element at i + 1
        1) If they are the same, then remove them; increment the counter by 1
        2) If not, continue through the process
    b. Check the counter to see if it's 0; if so, exit
4. Turn the StringBuilder into a string and return it

*/