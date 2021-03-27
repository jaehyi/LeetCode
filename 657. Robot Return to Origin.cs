public class Solution {
    public bool JudgeCircle(string moves) {
        int h = 0, v = 0;
        foreach(char move in moves){
            switch(move){
                case 'R':
                    h++;
                    break;
                case 'L':
                    h--;
                    break;
                case 'U':
                    v++;
                    break;
                case 'D':
                    v--;
                    break;
            }
        }
        if(h == 0 && v == 0) return true;
        else return false;
    }
}