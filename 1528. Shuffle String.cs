public class Solution {
    public string RestoreString(string s, int[] indices) {
        
        string[] newStringArray = new string[s.Length];
        char[] sToCharArray = s.ToCharArray();
        string newString = "";

        for (int i = 0; i < indices.Length; i++)
        {
            int indexInNewString = indices[i];
            string letterAtIndex = sToCharArray[i].ToString();
            newStringArray[indexInNewString] = letterAtIndex;
        }

        for (int i = 0; i < newStringArray.Length; i++)
        {
            newString += newStringArray[i];
        }
        return newString;   
    }
}