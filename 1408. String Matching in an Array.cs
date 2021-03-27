public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> resultList = new List<string>();
        foreach(string wordOuter in words)
        {
            foreach(string wordInner in words)
            {
                if(wordInner == wordOuter || wordOuter.Length >= wordInner.Length) continue;
                
                for(int i = 0 ; i <= wordInner.Length - wordOuter.Length;i++)  // i keeps track of index in the wordInner; j the index of the wordOuter
                {
                    if(wordOuter == wordInner.Substring(i,wordOuter.Length))
                    {
                        if(!resultList.Contains(wordOuter))
                        {
                            resultList.Add(wordOuter);
                            break;
                        }
                    }
                }
            }
        }
        
        return resultList;
    }
}

/*

Conditions/Constraints:
    1. Given an array of strings named words (string[] words)   
    2. Each word in the string array is unique
    3. Each word is made up of lower case English letters (Assumption is that no spaces in each word)
    4. The length of the array is between 1 and 100.
    5. Each word can be between 1 and 100 letters long.

Return value:
    A list made of elements from the argument array that are substrings of another word in any order

Example:
    Input: words = ["mass","as","hero","superhero"]
    Output: ["as","hero"]
    
Strategy:
    0. Create an instance of List to hold words.
    1. Create a loop that will compare each word in words to others in the list.
    2. Create an inner loop that will compare each word in the first loop to the rest.
        a. Begin comparision
        b. Create a counter variable initialized to 0.
        c. Compare the first word to each word that is not itself. -- Use IF condition to exclude itself
        d. If the length of the first word is greater than or equal to that of the other words, skip those words. -- Use IF condition (check c and d in the same IF         statement)
            For example, if the first word has 4 letters and the second has 2, we know the first word cannot be a substring of the second word.
            This can speed up the search.
        e. If c and d tests are passed, then see if the first word is a substring of the second word. If true, add the word to the list; if not, go to the next             word.
        f. Continue to the last word in the string array
    3. Return the list.
            


*/