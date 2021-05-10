public class Solution {
    public string[] FindWords(string[] words) {
        List<string> list = new List<string>();
        
        foreach(string word in words){
            if(word.Length == 1){
                list.Add(word);
                continue;
            }
            string wordInLowercase = word.ToLower();
            bool allLettersInOneRow = true;
            for(int i = 0; i < wordInLowercase.Length - 1; i++ ){
                if(GetIndex(wordInLowercase[i]) != GetIndex(wordInLowercase[i + 1])){
                    allLettersInOneRow = false;
                    break;
                }
            }
            
            if(allLettersInOneRow) list.Add(word);
        }
        
        return list.ToArray();
    }
    
    public int GetIndex(char letter){
        List<char> keyboardLayout = new List<char> {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
        int index = keyboardLayout.IndexOf(letter);
        if(index >= 0 && index <=9) return 1;
        else if(index >= 10 && index <=18) return 2;
        else return 3;
    }
}


/*
Conditions
    1. The words array will have at least one word and up to 20 words
    2. Each word will have at least one character and up to 100 characters
    3. Each word will consist of English letters (both lower and uppercase)
    
Return:
    A string array consisting of words that can be typed with letters on one row of the American keyboard
    
Strategy
    0. If words array has one word, then return it and exit
    1. Create a list to hold each word that meets the conditions
        List<string> list = new List<string>();
    2. Create a char array that holds all the characters (lowercase only)
        List<char> alphabets = new List<char> {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'}
        index 0 to 9 -> row 1
        index 10 to 18 -> row 2
        index 19 to 25 -> row 3
    3. Create a foreach loop that will enumerate each word in words array
        foreach(string word in words)
    4. Create a string variable that will hold each word enumerated in lowercase // This will make it easier to check for word
    5. Create a boolean variable that will be initialized to true; if it remains true at the end of the loop, then the word will be added to the list in Step 1
    6. Create a for loop that will iterate through each character
        for(int i = 0; i < word.Length - 1; i++ )
    7. Compare the index of the element at i with that of the element at i + 1
    8. If they are the same, go to the next i; if not, set the boolean variable to false and break out of the loop
    9. If the boolean value is true, then add the word examined to the list
    10. At the end of foreach loop, convert the list to string array and return it.


Create a helper method that will return row number of each character


*/