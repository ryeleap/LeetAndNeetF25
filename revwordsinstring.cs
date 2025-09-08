public class Solution {
    public string ReverseWords(string s) {
        List<string> words = new List<string>();
        bool word = false;
        int start = 0;
        int end = 0;
        string fin = "";

        for(int i = 0; i < s.Length; i++){
            // Console.WriteLine("index: " + i);
            if(!word && Char.IsLetterOrDigit(s[i]) && i != s.Length - 1){
                start = i;
                word = true;
            }
            else if(word && !Char.IsLetterOrDigit(s[i])){
                end = i - 1;
                words.Add(s.Substring(start, end - start + 1));
                start = 0;
                end = 0;
                word = false;
            }
            else if(i == s.Length - 1 && word && Char.IsLetterOrDigit(s[i])){
                end = i;
                words.Add(s.Substring(start, end - start + 1));
            }
            else if(i == s.Length - 1 && Char.IsLetterOrDigit(s[i])){
                words.Add(s[i].ToString());
            }
        }

        string[] stringy = words.ToArray();
        Array.Reverse(stringy);

        for(int i = 0; i < stringy.Length; i++){
            if(i == stringy.Length - 1){
                fin += stringy[i];
            }
            else{
                fin += stringy[i] + " ";
            }
        }

        return fin;
    }
}