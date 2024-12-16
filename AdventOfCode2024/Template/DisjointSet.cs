namespace Template;

public class DisjointSet<T> where T : IEquatable<T> {
    
    private readonly Dictionary<T, T> _parents = new ();
    
    public void MakeSet( T cell) {
        _parents[cell] = cell;
    }
    
    public T FindParent( T cell) {
        if (_parents[cell].Equals( cell)) {
            return cell;
        }

        return _parents[cell] = FindParent(_parents[cell]);
    }
    
    public void Union( T cell1, T cell2) {
        var p1 = FindParent(cell1);
        var p2 = FindParent(cell2);
        if (p1.Equals(p2)) {
            return;
        }

        _parents[p1] = p2;
    }
    
    public IReadOnlyList<HashSet<T>> GetSets() {
        var sets = new Dictionary<T, HashSet<T>>();
        foreach (var cell in _parents.Keys) {
            var parent = FindParent(cell);
            if (!sets.ContainsKey(parent)) {
                sets[parent] = new HashSet<T>();
            }

            sets[parent].Add(cell);
        }

        return sets.Values.ToList();
    }

    /// <summary>
    /// Returns a lookup of the parents to the children
    /// </summary>
    public ILookup<T, T> ParentsToChildren() => _parents.ToLookup(kv => kv.Value, kv => kv.Key);
}