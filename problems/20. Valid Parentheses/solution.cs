public bool IsValid(string s) {
    Dictionary<char, char> brackets = new Dictionary<char, char>();
    brackets.Add('(', ')');
    brackets.Add('{', '}');
    brackets.Add('[', ']');

    if (string.IsNullOrEmpty(s))
        return true;

    if (s.Length % 2 != 0)
        return false;

    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (stack.Count == 0)
        {
            if (brackets.ContainsKey(s[i]))
                stack.Push(s[i]);
            else
                return false;
        }

        else if (brackets[stack.Peek()] == s[i])
            stack.Pop();

        else if (brackets.ContainsKey(s[i]))
            stack.Push(s[i]);
    }

    if (stack.Count == 0)
        return true;
    else
        return false;
}
