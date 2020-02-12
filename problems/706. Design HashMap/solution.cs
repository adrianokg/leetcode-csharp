public class MyHashMap {
    Dictionary<int, int> hashMap = new Dictionary<int, int>();
    /** Initialize your data structure here. */
    public MyHashMap()
    {
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
        if (!hashMap.ContainsKey(key))
            hashMap.Add(key, value);
        else
        {
            hashMap.Remove(key);
            hashMap.Add(key, value);
        }
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        if (hashMap.Keys.Contains(key))
            return hashMap[key];
        else
            return -1;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        if (hashMap.Keys.Contains(key))
            hashMap.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */