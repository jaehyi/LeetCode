public class RecentCounter {
    
    // private List<int> requests = new List<int>();
    private Queue<int> requests = new Queue<int>();
    public RecentCounter() {

    }
    
    public int Ping(int t) {
        //int counter = 0;
        //requests.Add(t);
        /* Works, but not optimized
        foreach(int request in requests){
            if(request >= t - 3000 && request <= t) counter++;
        }
        */
        
        /* Better than the first one, but still slow
        for(int i = requests.Count - 1; i >= 0; i--)
        {
            if(requests[i] >= t - 3000)
                counter++;    
            else
                return counter;
        }
        */
        
        requests.Enqueue(t);
        while(requests.Count > 0)
        {
            if(requests.First() < t - 3000)
                requests.Dequeue();
            else break;
        }
        
        return requests.Count;

    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */