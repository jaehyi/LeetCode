public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        List<char> list = new List<char>();
        foreach(char c in s)
            list.Add(c);
        foreach(char c in t)
            list.Remove(c);
        if(list.Count == 0) return true;
        else return false;
    }
}