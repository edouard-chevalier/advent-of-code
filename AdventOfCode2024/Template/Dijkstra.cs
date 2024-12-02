namespace Template;

/// <summary>
/// The algorithm to find the shortest path from some specific nodes to all other nodes
/// works only for non-negative weights
/// T is the node
/// </summary>
public static class Dijkstra {

    /// <summary>
    /// Shortest path from some specific nodes to all other nodes
    /// T needs to be comparable as we use a SortedSet for the minHeap (maybe can switch to a true PriorityQueue)
    /// </summary>
    /// <param name="nextWithWeight">gives adjacents nodes with corresponding  weights</param>
    /// <param name="start">the different starts</param>
    public static IReadOnlyList<(T node, long distance)> ShortestPath<T>(Func<T, IEnumerable<(T next, long weight)>> nextWithWeight,
        params T[] start) where T:IComparable<T>
    {
        var h = new SortedSet<HeapKey<T>>();
        var dist = new Dictionary<T, long>();
        long GetDist(T p) => dist.TryGetValue(p, out var d) ? d : long.MaxValue;
        
        foreach (var s in start) {
            h.Add(new HeapKey<T>(s, 0));
            dist[s] = 0;
        }
        while (h.Count > 0)
        {
            var current = h.First();
            h.Remove(current);
            var node = current.Id;
            foreach (var next in nextWithWeight(node))
            {
                var newDist = GetDist(node) + next.weight;
                if (newDist < GetDist(next.next))
                {
                    dist[next.next] = newDist;
                    h.Add(new HeapKey<T>(next.next, newDist));
                }
            }
        }

        return dist.Select(kv => (kv.Key, kv.Value)).ToArray();
    }

    private class HeapKey<T> : IComparable<HeapKey<T>> where T:IComparable<T>{
        public HeapKey(T id, long value)
        {
            Id = id;
            Value = value;
        }

        public T Id { get; private set; }
        public long Value { get; private set; }

        public int CompareTo(HeapKey<T> other) {
            var result = Value.CompareTo(other.Value);
            return result == 0 ? Id.CompareTo(other.Id) : result;
        }
    }
}