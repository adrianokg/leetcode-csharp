public bool IsSubsequence(string s, string t) {
    if (string.IsNullOrEmpty(s))
        return true;

    int index = 0;
    var sChar = s.ToCharArray();
    var tChar = t.ToCharArray();

    for (int i = 0; i < t.Length; i++ ) {
        if (tChar[i] == sChar[index])
            index++;

        if (index >= s.Length)
            return true;
    }

    return false;
}
