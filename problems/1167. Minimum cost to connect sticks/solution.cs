public int connectSticks(int[] sticks)
{
    int cost = 0;
    List<int> minHeap = new List<int>();

    foreach (var stick in sticks)
    {
        minHeap.Add(stick);
    }

    while (minHeap.Count > 1)
    {
        minHeap.Sort();

        int element1 = minHeap[0];
        minHeap.RemoveAt(0);
        int element2 = minHeap[0];
        minHeap.RemoveAt(0);

        int sum = element1 + element2;
        cost += sum;
        minHeap.Add(sum);
    }

    return cost;
}
