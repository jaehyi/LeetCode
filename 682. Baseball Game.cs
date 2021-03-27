public class Solution {
    public int CalPoints(string[] ops) {
        
        List<int> scores = new List<int>();
        for(int i = 0; i < ops.Length; i++){
            if(int.TryParse(ops[i], out int number)) scores.Add(number);
            else{
                if(ops[i] == "+") scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
                if(ops[i] == "D") scores.Add(scores[scores.Count - 1] * 2);
                if(ops[i] == "C") scores.RemoveAt(scores.Count - 1);
            }
        }
        
        int sum = 0;
        foreach(var score in scores){
            sum += score;
        }
        
        return sum;
    }
}


/*

scores of past rounds may affect future rounds' scores
start with an empty record
given a list of strings (ops)
 ops[i]
 

return the sum of all the scores in ops


Strategy:

1. Create a List to store all scores
2. Create a For loop to iterate through all elements in string[] ops
    a. Create a switch statement
 if it is an integer, record it as a score
 if "+", add two previous scores and record it as a new score
 if "D", double the previous score and record it as a new score
 if "C", delete the previous score from ops   




*/