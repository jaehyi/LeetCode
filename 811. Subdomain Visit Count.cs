public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string cpdomain in cpdomains){
            if(dict.ContainsKey(cpdomain.Substring(cpdomain.IndexOf(" ") + 1))) dict[cpdomain.Substring(cpdomain.IndexOf(" ") + 1)] += GetCount(cpdomain); // this blocks gets the whole domain
            else dict[cpdomain.Substring(cpdomain.IndexOf(" ") + 1)] = GetCount(cpdomain);
            
            if(dict.ContainsKey(cpdomain.Substring(cpdomain.LastIndexOf(".") + 1))) dict[cpdomain.Substring(cpdomain.LastIndexOf(".") + 1)] += GetCount(cpdomain); // this block gets the last part of the domain
            else dict[cpdomain.Substring(cpdomain.LastIndexOf(".") + 1)] = GetCount(cpdomain);
            
            if(cpdomain.IndexOf(".") != cpdomain.LastIndexOf(".")){ // The address has 2 "." characters
                if(dict.ContainsKey(cpdomain.Substring(cpdomain.IndexOf(".") + 1))) dict[cpdomain.Substring(cpdomain.IndexOf(".") + 1)] += GetCount(cpdomain); // this blocks gets the middle part of the domain
                else dict[cpdomain.Substring(cpdomain.IndexOf(".") + 1)] = GetCount(cpdomain);
            }
        }
        
        List<string> list = new List<string>();
        
        foreach(var item in dict){
            list.Add(item.Value + " " + item.Key);
        }
        
        return list;
        
        
    }
    
    public int GetCount(string cpdomain){
        int indexOfSpace = cpdomain.IndexOf(" ");
        return int.Parse(cpdomain.Substring(0, indexOfSpace));
    }
}