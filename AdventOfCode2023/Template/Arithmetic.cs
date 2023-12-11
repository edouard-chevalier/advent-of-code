namespace Template;

public class Arithmetic {
    
    /// <summary>
    /// Plus grand denominateur commun
    /// </summary>
    public static long gcd(long n1, long n2) {
        if (n2 == 0) {
            return n1;
        }

        return gcd(n2, n1 % n2);
    }
    
    /// <summary>
    /// Plus grand denominateur commun
    /// </summary>
    public static long gcd(params long [] numbers) {
        return numbers.Aggregate(gcd);
    }

    /// <summary>
    /// Plus petit multiple commun
    /// </summary>
    public static long lcm(params long[] numbers) {
        return numbers.Aggregate((s, val) => s * val / gcd(s, val));
    }
}