public class Solution {
    public int LengthOfLastWord(string s) {
                        
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] != ' ')
            {
                for(int j = i; j >= 0; j--)
                {
                    if(s[j] == ' ') return i - j;
                    if(j == 0) return i + 1;
                }
            }
        }
        return 0;
    }
}
/*

string s
1. consists of some words separated by spaces (could be one or more)
2. may not contain any word
3. may contain a space only (in which case, return 0)
4. A word consists of non-space characters only (the length could be 1 to 10,000)

return value: the length of the last word (int)


step 1: Loop through each character starting with the last character in the string s.  It will loop to the first character, unless it can exit early.
step 2: If it finds a non-space character, mark the index, then look to see if there is a space character.
    step 2a: If it finds a space character, then return the index of the first non-space character subtracted by the index of the space character
    step 2b:  If it doesn't find one, then return the index of the first non-space character subtracted by the first index of the string
setp 3: If it does NOT find a non-space character at the end of the loop, then return 0;


*/