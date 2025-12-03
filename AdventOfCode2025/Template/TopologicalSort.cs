namespace Template;

public class TopologicalSort
{
    /// <summary>
    /// Topological sort. throws exception if there is a cycle
    /// </summary>
    public static IReadOnlyList<T> SortNodes<T>( IReadOnlyList<T> nodes , Func<T, IEnumerable<T>> children)  where T: IEquatable<T> {
        var visited = new HashSet<T>();
        var temporary = new HashSet<T>();
        var result = new List<T>();

        void Visit(T node) {
            if (temporary.Contains(node)) {
                throw new Exception("Cycle detected");
            }

            if (visited.Contains(node)) {
                return;
            }

            temporary.Add(node);
            foreach (var child in children(node)) {
                Visit(child);
            }

            temporary.Remove(node);
            visited.Add(node);
            result.Add(node);
        }

        while (true) {
            if (nodes.All(n=> visited.Contains(n))) {
                break;
            }
            var notVisited = nodes.First(n => !visited.Contains(n));

            Visit(notVisited);
        }


        result.Reverse();
        return result;
    }
}