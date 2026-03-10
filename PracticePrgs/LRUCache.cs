public class LRUCache {
    Dictionary<int, int> cache = new();
    List<int> LRUlist = new();
    public int cacheLimit = 0;
    public LRUCache(int capacity) {
        cacheLimit = capacity;
    }
    
    public int Get(int key) {
        if (cache.TryGetValue(key, out int val))
        {
            //update LRU
            LRUlist.Remove(key);
            LRUlist.Add(key);
            return val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.TryGetValue(key, out int val))
        {
            //update value
            cache[key] = value;
            LRUlist.Remove(key);
            LRUlist.Add(key);
            return;
        }
        //if capacity reached, clear up LRU key-value
        if (cache.Count == cacheLimit)
        {
            int LRUkey = LRUlist[0];
            LRUlist.Remove(LRUkey);
            cache.Remove(LRUkey);
        }
        cache[key] = value;
        LRUlist.Add(key);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */