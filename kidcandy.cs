public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    bool[] result = new bool[candies.Length];
    int max = candies.Max();  

    for(int i = 0; i < candies.Length; i++){
        result[i] = candies[i] + extraCandies >= max;
    }  

    return result;
    }
}