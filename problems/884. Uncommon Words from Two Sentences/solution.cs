    public string[] UncommonFromSentences(string A, string B) {
        var concat = A + " " + B;
        var splitted = concat.Split(" ");

        var common = new Dictionary<string, int>();

        for (var i = 0; i < splitted.Length; i++)
        {
            if (!common.ContainsKey(splitted[i]))
                common.Add(splitted[i], 1);
            else
                common[splitted[i]]++;
        }

        var uncommon = new List<string>();

        foreach(var word in common)
        {
            if (word.Value == 1)
                uncommon.Add(word.Key);
        }

        return uncommon.ToArray();
    }