public int NumJewelsInStones(string J, string S) {
    int count = 0;

    if(J.Length != 0 && S.Length != 0)
    {
        for(var i = 0; i < S.Length; i++)
        {
            if(J.Contains(S[i]))
            {
                count++;
            }
        }

        return count;
    }
    else
    {
        return count;
    }
}
