public class Solution {
    public int NumberOfMatches(int n) {
        return getNumberOfMatches(n,0);
    }
    
    public int getNumberOfMatches(int numberOfTeams, int numberOfMatches){
        if(numberOfTeams == 1) return numberOfMatches;
        else{
            if(numberOfTeams % 2 == 0) {
                numberOfMatches += numberOfTeams / 2;
                numberOfTeams = numberOfTeams / 2;
            }
            else {
                numberOfMatches += (numberOfTeams - 1) / 2;
                numberOfTeams = (numberOfTeams - 1)/ 2 + 1;
            }
            return getNumberOfMatches(numberOfTeams, numberOfMatches);
        }
    }
}