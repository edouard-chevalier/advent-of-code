namespace Template;

public class DisjointSet<T> where T : IEquatable<T> {
    
    private readonly Dictionary<T, T> _parents = new ();
    
    public void Add( T cell) {
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

    /// <summary>
    /// Returns a lookup of the parents to the children
    /// </summary>
    public ILookup<T, T> ToLookup() => _parents.ToLookup(kv => kv.Value, kv => kv.Key);
}