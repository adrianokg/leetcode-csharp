public bool UniqueOccurrences(int[] arr) {
    var ocurrences = new Dictionary<int, int>();

    foreach (var i in arr)
    {
        if (!ocurrences.ContainsKey(arr[i]))
            ocurrences.Add(arr[i], 1);
        else
            ocurrences[arr[i]]++;
    }

    var hashSet = new HashSet<int>(ocurrences.Values);

    return ocurrences.Count == hashSet.Count;
}
