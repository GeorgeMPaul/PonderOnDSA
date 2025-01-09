public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int cmax = int.MinValue;
        for (int i=0;i<candies.Length;i++){
            if (candies[i]>cmax){cmax=candies[i];}
        }
        List<bool> extraCan= new List<bool>();
        for (int i=0;i<candies.Length;i++){
            if (candies[i]+extraCandies>=cmax){
                extraCan.Add(true);
            }
            else{
                extraCan.Add(false);
            }
        }
        return extraCan;
    }
}
