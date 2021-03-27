public class Solution {
    public string ReverseWords(string s) {
        
        //string result = "";
        if(s.Length == 0) return "";
        
        StringBuilder sb = new StringBuilder();
        
        // char[] tempArray = new char[s.Length];
        
        int startIndex = 0;
        int endIndex;
        int tempStartIndex;
        
        for (int i = 0; i < s.Length; i++) // to ensure we loop through all the characters in string s
        {
            if(s[i] == ' ')
            {
                endIndex = i - 1;
                // tempStartIndex = startIndex;
                for (int j = endIndex; j >= startIndex; j--)    
                {
                    // tempArray[tempInt++] = s[j];
                    // result += s[j];
                    sb.Append(s[j]);
                }
                // startIndex = tempInt;
                startIndex = endIndex + 2;
                // tempArray[startIndex++] = ' ';
                sb.Append(" ");
            }
        }
        
        // tempStartIndex = startIndex;
        for (int j = s.Length - 1; j >= startIndex; j--)    
        {
            // tempArray[tempInt++] = s[j];
            // result += s[j];
            sb.Append(s[j]);
        }
        
        // string temp = "";
        // foreach(char c in tempArray)
        // {
        //     temp += c;
        // }
        
        // return result;
        return sb.ToString();
        
    }
}/*

I kept on getting "Time Limit Exceed" error, so I resorted to using StringBuilder

What language?  Do we have a choice?
        Question 1:  Can a string be empty???  Return the empty string.  // Check the length of the string
        What is the max string length? 2 32  //  string == immutable (affects memory space)  StringBuilder == mutable
        Condition: Each word is separated by a single space; there are no extra spaces in the string.
        
        What am I returning?  String
                    
        string: sentence that may not have any word or one or more words.
            
            treat the string as an array of characters
            
            Create a temp char array with the size that is equal to the length of the string; this will hold the reversed words
            then start looping through each character looking for a space
            
            We mark the starting index
                
            if there is no space, reverse the string using for loop and return it
        
            if there is a space character:  
                we mark the end index (space index - 1), reverse the word, and input it into the temp char array.  
                we reset the starting index to (space index + 1)
                We repeat the process until we reach the end of the string length.  
                Last thing we have to is to turn the char array into a string before returning it.
                
            
                    
                
        */