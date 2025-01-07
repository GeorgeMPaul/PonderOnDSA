public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new List<char>();
        char[] cv = s.ToCharArray();

        foreach(char c in s){
            if ("aeiouAEIOU".Contains(c))
                vowels.Add(c);
        }
        vowels.Reverse();

        var j=0;
        for (int i=0;i<s.Length;i++){
            if ("aeiouAEIOU".Contains(s[i])){
                cv[i] = vowels[j];
                j++;
            }
        }
        return new string(cv);
    }
}
