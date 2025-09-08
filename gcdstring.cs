public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        string copy = str1.Length >= str2.Length ? str2 : str1;
                
        for(int i = copy.Length - 1; i >= 0; i--){
            if(str1.Length % copy.Length == 0 && str2.Length % copy.Length == 0 && str1.Replace(copy, "") == "" && str2.Replace(copy, "") == ""){
                return copy;
            }
            else
                copy = copy.Substring(0, copy.Length - 1);
        }
        return "";
    }
}