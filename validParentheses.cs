public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char ch in s) {
            if (ch == '(' || ch == '{' || ch == '[') {
                st.Push(ch);
                continue;
            }
            else if (ch == ')') {
                if (st.Count == 0 || st.Peek() != '(') return false;
            }
            else if (ch == '}') {
                if (st.Count == 0 || st.Peek() != '{') return false;
            }
            else if (ch == ']') {
                if (st.Count == 0 || st.Peek() != '[') return false;
            }
            st.Pop();
        }
        return st.Count == 0;
    }
}
