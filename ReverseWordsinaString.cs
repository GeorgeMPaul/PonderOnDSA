public class Solution {
    public string ReverseWords(string s) {
        return string.Join(" ",s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}
