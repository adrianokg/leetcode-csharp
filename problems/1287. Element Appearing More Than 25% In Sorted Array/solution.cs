public int FindSpecialInteger(int[] arr) {
    var dictInt = new Dictionary<int, int>();

    foreach(var i in arr)
    {
        if (dictInt.ContainsKey(i))
            dictInt[i]++;
        else
            dictInt.Add(i, 1);
    }

    var sortedDict = from item in dictInt orderby item.Value descending select item;
    
    return sortedDict.First().Key;
}
