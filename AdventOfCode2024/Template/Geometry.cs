namespace Template;

public class Geometry
{
    
    /// <summary>
    /// Try to find the intersection of two lines defined by a1*x + b1*y + c1 = 0 and a2*x + b2*y +  c2 = 0
    /// </summary>
    public bool TryFindIntersection( long a1, long b1, long c1, long a2, long b2, long c2, out long x, out long y) {
        x = 0;
        y = 0;
        long det = a1 * b2 - a2 * b1;
        if (det == 0) {
            return false;
        }

        var nx = (c2 * b1 - c1 * b2 );
        if( nx % det != 0) {
            return false;
        }
        x = nx / det;
        var ny = ( a2 * c1 -a1 * c2 );
        if( ny % det != 0) {
            return false;
        }
        y = ny / det;
        return true;
    }
}