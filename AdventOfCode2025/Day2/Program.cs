const string inputReal = @"749639-858415,65630137-65704528,10662-29791,1-17,9897536-10087630,1239-2285,1380136-1595466,8238934-8372812,211440-256482,623-1205,102561-122442,91871983-91968838,62364163-62554867,3737324037-3737408513,9494926669-9494965937,9939271919-9939349036,83764103-83929201,24784655-24849904,166-605,991665-1015125,262373-399735,557161-618450,937905586-937994967,71647091-71771804,8882706-9059390,2546-10476,4955694516-4955781763,47437-99032,645402-707561,27-86,97-157,894084-989884,421072-462151";

static string Load() {
    return File.ReadAllText(Path.Combine("D:\\code\\advent-of-code\\AdventOfCode2025\\data", $"{inputReal}.txt"));
}

const string inputTest = @"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";


long Pow(int scale)
{
    long result = 1;
    while (scale-- > 0) {
        result *= 10;
        }
    return result;
}
IReadOnlyList<long> InvalidIdsInFixScale(int scale,long from, long to) {

    if (scale % 2 == 1) {
        return [];
    }
    var halfScale = scale / 2;

    long possible = long.Parse(from.ToString()[..halfScale]);
    long possibleRepeated =  possible * Pow(halfScale) + possible;
    var res = new List<long>();
    while ( possibleRepeated <= to)
    {
        if (possibleRepeated >= from)
        {
            res.Add( possibleRepeated);
        }
        possible++;
        possibleRepeated = possible * Pow(halfScale) + possible;
    }
    return res ;
}
long InvalidIds(long from, long to)
{
    long res = 0;
    int fDigit = from.ToString().Length;
    int tDigit = to.ToString().Length;
    for (int i = fDigit; i <= tDigit; i++) {
        var currentFrom = i == fDigit ? from : Pow(i-1);
        var currentTo = i == tDigit ? to : Pow(i) - 1;
        var l = InvalidIdsInFixScale(i, currentFrom, currentTo);
        Console.WriteLine(
            $"[{from}-{to}] -- [{currentFrom} - {currentTo}]: " + (l.Any() ? string.Join(",", l) : "noId"));
        res += l.Sum();
    }

    return res;

}
void Part1(string input) {
    if (input.StartsWith("day")) {
        input = Load();
    }
    var lines = input.Split(Environment.NewLine).First().Split(",");
    long res = 0;
    foreach (var line in lines)
    {
        var a = line.Split("-");
        res += InvalidIds(long.Parse(a[0]), long.Parse(a[1]));
    }
    Console.WriteLine(res);
    
}

long Repeat(long number,int numberScale, int n)
{
    var res = number;
    n--;
    while (n-- > 0)
    {
        res = res * Pow(numberScale) + number;
    }

    return res;
}
IReadOnlyList<long> InvalidIdsInFixScaleRepeatedN(int scale,int n,long from, long to) {

    if (scale % n != 0)
    {
        return [];
    }
    
    var scaleSingle = scale / n;
    

    long possible = long.Parse(from.ToString()[..scaleSingle]);
    long possibleRepeated =  Repeat(possible, scaleSingle,n);
    var res = new List<long>();
    while ( possibleRepeated <= to)
    {
        if (possibleRepeated >= from)
        {
            res.Add( possibleRepeated);
        }
        possible++;
        possibleRepeated = Repeat(possible, scaleSingle,n);
    }
    return res ;
}

IReadOnlyList<long> InvalidIdsInFixScale2(int scale,long from, long to) {

    var halfScale = scale / 2;

  
    var res = new HashSet<long>();
    for (int i = 2; i <= scale; i++)
    {
        res.UnionWith(InvalidIdsInFixScaleRepeatedN(scale, i, from,to));
    }
    return res.Order().ToArray();
}

long InvalidIds2(long from, long to)
{
    long res = 0;
    int fDigit = from.ToString().Length;
    int tDigit = to.ToString().Length;
    for (int i = fDigit; i <= tDigit; i++) {
        var currentFrom = i == fDigit ? from : Pow(i-1);
        var currentTo = i == tDigit ? to : Pow(i) - 1;
        var l = InvalidIdsInFixScale2(i, currentFrom, currentTo);
        Console.WriteLine(
            $"[{from}-{to}] -- [{currentFrom} - {currentTo}]: " + (l.Any() ? string.Join(",", l) : "noId"));
        res += l.Sum();
    }

    return res;

}
void Part2(string input) {
    if (input.StartsWith("day")) {
        input = Load();
    }
    var lines = input.Split(Environment.NewLine).First().Split(",");
    long res = 0;
    foreach (var line in lines)
    {
        var a = line.Split("-");
        res += InvalidIds2(long.Parse(a[0]), long.Parse(a[1]));
    }
    Console.WriteLine(res);
    
}

//Part1(inputReal);// 18880158752: too low
Part2(inputReal);