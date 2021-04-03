public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = 0;
        for(int i = lowLimit; i <= highLimit; i++){
            int boxNumber = computeBoxNumber(i);
            if (!dict.ContainsKey(boxNumber)) dict[boxNumber] = 1;
            else dict[boxNumber]++;
            
            if (result < dict[boxNumber]) result = dict[boxNumber];
        }
        
        return result;
        
    }
    
    private int computeBoxNumber(int ballNumber){
        int result = 0;
        int quotient = ballNumber;
        
        while(quotient != 0){
            result += quotient % 10;
            quotient /= 10;
        }
        
        return result;
    }
}

/*
Facts/Assumptions: 
    1. All the balls are numbered sequentially from lowLimit to highLimit, both inclusive -- I can use For loop to iterate through all the balls
    2. Each ball goes into a box whose number is composed by adding each digit of the ball number (i.e. ball # 123 goes to box # 6 (1+2+3))
    3. The ball number range is from 1 to 10^5, inclusive

Pseudo code:
    1. Set up a dictionary <int, int> to keep track of box #s and the number of balls in the corresponding box
    2. Create an int variable and initialize it to 0; this will keep track of the highest value seen.
    3. Create a function that computes box numbers.
    4. Create a For loop to iterate from lowLimit to highLimit
        a. If the box number is not in the dictionary, add it with an initial value of 1
        b. If the box number is present, then increment the value by 1
        c. Compare the value to the int variable in Step 2. If the former is greater than the latter, then update the int variable to the value.
    5. Return the int variable
*/