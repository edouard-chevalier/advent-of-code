// See https://aka.ms/new-console-template for more information


using Template;

const string inputReal = @"805A
682A
671A
973A
319A";
const string inputTest = @"029A
980A
179A
456A
379A";

const char Up = '^';
const char Down = 'v';
const char Left = '<';
const char Right = '>';
const char Action = 'A';
char[][] directional = new []{" ^A","<v>"}.Select( x => x.ToCharArray()).ToArray();
char[][] numeric = new[] { "789", "456", "123", " 0A" }.Select(x => x.ToCharArray()).ToArray();
void Part1(string input) {
    var directionalPaths = GetPathsByChar(directional);
    var numericPaths = GetPathsByChar(numeric);
    
    var lines = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
    List<RecursiveChar> NeedToTypeDirectionsForDir(ReadOnlySpan<char> requested, char from) {
        var res = new List<RecursiveChar>();
        if( requested.Length == 0) {
            return res;
        }
        var to = requested[0];
        var paths = directionalPaths[(from, to)];
        var next = NeedToTypeDirectionsForDir(requested[1..], to);
        foreach (var path in paths) {
            var prefix = path.Select(d => d switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }).ToList();
            prefix.Add('A');
            res.Add(new RecursiveChar { Prefix = prefix, Next = next });
        }

        return res;
    }
    List<RecursiveChar> NeedToTypeDirectionsForNum(ReadOnlySpan<char> requested, char from) {
        var res = new List<RecursiveChar>();
        if( requested.Length == 0) {
            return res;
        }
        var to = requested[0];
        var paths = numericPaths[(from, to)];
        var next = NeedToTypeDirectionsForNum(requested[1..], to);
        foreach (var path in paths) {
            var prefix = path.Select(d => d switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }).ToList();
            prefix.Add('A');
            res.Add(new RecursiveChar { Prefix = prefix, Next = next });
        }

        return res;
    }

    long sum = 0;
    foreach( var line in lines.Skip(1).Take(1)) {
        string shortest = null;
        string robot2inS = null;
        string manualS = null;
        Console.WriteLine("Computing for " + new string(line));
        var robot1 = NeedToTypeDirectionsForNum(line.AsSpan(), Action).SelectMany(x => x.ToExplicitList()).ToList();
        foreach (var robot2In in robot1) {
            var robot2 = NeedToTypeDirectionsForDir(robot2In.ToArray(), Action).SelectMany(x => x.ToExplicitList()).ToList();
            foreach (var manualIn in robot2) {
                var manual = NeedToTypeDirectionsForDir( manualIn.ToArray(), Action).SelectMany(x => x.ToExplicitList()).ToList();
                foreach (var m in manual) {
                    if( shortest == null || m.Count < shortest.Length) {
                        shortest = new string(m.ToArray());
                        robot2inS = new string(robot2In.ToArray());
                        manualS = new string(manualIn.ToArray());
                    }
                   // Console.WriteLine(m.Count);
                   // Console.WriteLine(new string(m.ToArray()));
                }
            }
        }
        
        Console.WriteLine(shortest);
        Console.WriteLine(manualS);
        Console.WriteLine(robot2inS);
        sum += shortest.Length * int.Parse( new string( line).Substring(0, line.Length - 1));
    }
    Console.WriteLine(sum);
    
}


void Part2Sav(string input) {
    var directionalPaths = GetPathsByChar(directional, true);
    var directionalPathsChar = new Dictionary<( char from, char to), IReadOnlyList<char>> ();
    foreach (var path in directionalPaths) {
        var res = new List<char>( path.Value.Count + 1);
        foreach (var direction in path.Value[0]) {
            res.Add(direction switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            });
        }
        res.Add('A');
        directionalPathsChar[path.Key] = res;
    }
    var numericPaths = GetPathsByChar(numeric);
    
    var lines = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
   
    List<RecursiveChar> NeedToTypeDirectionsForNum(ReadOnlySpan<char> requested, char from) {
        var res = new List<RecursiveChar>();
        if( requested.Length == 0) {
            return res;
        }
        var to = requested[0];
        var paths = numericPaths[(from, to)];
        var next = NeedToTypeDirectionsForNum(requested[1..], to);
        foreach (var path in paths) {
            var prefix = path.Select(d => d switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }).ToList();
            prefix.Add('A');
            res.Add(new RecursiveChar { Prefix = prefix, Next = next });
        }

        return res;
    }

    long sum = 0;
    foreach( var line in lines) {
        //string shortest = null;
        long shortest = -1;
        Console.WriteLine("Computing for " + new string(line));
        var robotNum = NeedToTypeDirectionsForNum(line.AsSpan(), Action).SelectMany(x => x.ToExplicitList()).ToList();
        //var cache = new Dictionary<(int robot, char from, char to), long>();
        foreach (var robot2In in robotNum) {
            int robotCount = 16;
            var robotInput = new long[robotCount];
            /*for( int i = 0; i < robotCount; i++) {
                robotInput[i] = new List<char>();
            }*/
            

            void DoType(int robot, char from, char to) {
                if (robot == robotCount) {
                    return;
                }
                /*if (cache.TryGetValue((robot, from, to), out var result)) {
                    robotInput[robot] += result;
                    return;
                }*/
                var paths = directionalPathsChar[(from, to)];
                var fromNext = Action;
                foreach (var toNext in paths) {
                    DoType(robot + 1, fromNext, toNext);
                    robotInput[robot]++;
                    fromNext = toNext;
                }
            }
            var numFrom = Action;
            foreach (var numTo in robot2In) {
                DoType(0, numFrom, numTo);
                numFrom = numTo;
            }
            //Console.WriteLine(new string(robotInput[0].ToArray()));
            //Console.WriteLine(new string(robotInput[1].ToArray()));
            if( shortest <0 || robotInput[^1] < shortest) {
                shortest = robotInput[^1];
            }
        }
        var codeValue = int.Parse( new string( line).Substring(0, line.Length - 1));
        sum += shortest * codeValue;
        Console.WriteLine($"for code {codeValue}, shortest is {shortest}. current sum is {sum}");
    }
    Console.WriteLine(sum);
    
}

void Part2TooMuch(string input) {
    var directionalPaths = GetPathsByChar(directional, true);
    var directionalPathsChar = new Dictionary<( char from, char to), IReadOnlyList<char>> ();
    foreach (var path in directionalPaths) {
        var res = new List<char>( path.Value.Count + 1);
        foreach (var direction in path.Value[0]) {
            res.Add(direction switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            });
        }
        res.Add('A');
        directionalPathsChar[path.Key] = res;
    }
    var numericPaths = GetPathsByChar(numeric);
    
    var lines = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
   
    List<RecursiveChar> NeedToTypeDirectionsForNum(ReadOnlySpan<char> requested, char from) {
        var res = new List<RecursiveChar>();
        if( requested.Length == 0) {
            return res;
        }
        var to = requested[0];
        var paths = numericPaths[(from, to)];
        var next = NeedToTypeDirectionsForNum(requested[1..], to);
        foreach (var path in paths) {
            var prefix = path.Select(d => d switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }).ToList();
            prefix.Add('A');
            res.Add(new RecursiveChar { Prefix = prefix, Next = next });
        }

        return res;
    }

    long sum = 0;
    foreach( var line in lines) {
        //string shortest = null;
        long shortest = -1;
        Console.WriteLine("Computing for " + new string(line));
        var robotNum = NeedToTypeDirectionsForNum(line.AsSpan(), Action).SelectMany(x => x.ToExplicitList()).ToList();
        
        foreach (var robot2In in robotNum) {
            int robotCount = 1;
            long current = 0;
            /*for( int i = 0; i < robotCount; i++) {
                robotInput[i] = new List<char>();
            }*/
            var cache = new Dictionary<(int robot, char from, char to), long>();


            void DoType(int robot, char from, char to) {
                if (robot == robotCount) {
                    current += directionalPathsChar[(from, to)].Count;
                    return;
                }

                if (cache.TryGetValue((robot, from, to), out var result)) {
                    current += result;
                    return;
                }

                var before = current;
                var paths = directionalPathsChar[(from, to)];
                var fromNext = Action;
                foreach (var toNext in paths) {
                    DoType(robot + 1, fromNext, toNext);
                    fromNext = toNext;
                }
                cache[(robot, from, to)] = current - before;
            }
            var numFrom = Action;
            foreach (var numTo in robot2In) {
                DoType(0, numFrom, numTo);
                numFrom = numTo;
            }
            //Console.WriteLine(new string(robotInput[0].ToArray()));
            //Console.WriteLine(new string(robotInput[1].ToArray()));
            if( shortest <0 || current < shortest) {
                shortest = current;
            }
        }
        var codeValue = int.Parse( new string( line).Substring(0, line.Length - 1));
        sum += shortest * codeValue;
        Console.WriteLine($"for code {codeValue}, shortest is {shortest}. current sum is {sum}");
    }
    Console.WriteLine(sum);
    
}

void Part2(string input) {
    var directionalPaths = GetPathsByChar(directional);
    var directionalPathsChar = new Dictionary<( char from, char to), IReadOnlyList<IReadOnlyList<char>>> ();
    foreach (var path in directionalPaths) {
        var res = new List<IReadOnlyList<char>>( path.Value.Count);
        foreach (var direction in path.Value) {
            var tmp = new List<char>(direction.Count + 1);
            tmp.AddRange(direction.Select(c=>c switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }) );
            tmp.Add('A');
            res.Add(tmp);
        }
        directionalPathsChar[path.Key] = res;
    }
    var numericPaths = GetPathsByChar(numeric);
    
    var lines = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();
   
    List<RecursiveChar> NeedToTypeDirectionsForNum(ReadOnlySpan<char> requested, char from) {
        var res = new List<RecursiveChar>();
        if( requested.Length == 0) {
            return res;
        }
        var to = requested[0];
        var paths = numericPaths[(from, to)];
        var next = NeedToTypeDirectionsForNum(requested[1..], to);
        foreach (var path in paths) {
            var prefix = path.Select(d => d switch {
                Grid.Direction.Up => Up,
                Grid.Direction.Down => Down,
                Grid.Direction.Left => Left,
                Grid.Direction.Right => Right,
                _ => throw new ArgumentOutOfRangeException()
            }).ToList();
            prefix.Add('A');
            res.Add(new RecursiveChar { Prefix = prefix, Next = next });
        }

        return res;
    }

    long sum = 0;
    foreach( var line in lines/*.Skip(1).Take(1)*/) {
        //string shortest = null;
        long shortest = -1;
        Console.WriteLine("Computing for " + new string(line));
        var robotNum = NeedToTypeDirectionsForNum(line.AsSpan(), Action).SelectMany(x => x.ToExplicitList()).ToList();
        var cache = new Dictionary<(int robot, char from, char to), long>();

        foreach (var robot2In in robotNum) {
            int robotCount = 24;
            long current = 0;
            /*for( int i = 0; i < robotCount; i++) {
                robotInput[i] = new List<char>();
            }*/


            void DoType(int robot, char from, char to) {
                if (robot == robotCount) {
                    current += directionalPathsChar[(from, to)].Min(x => x.Count);
                    return;
                }

                if (cache.TryGetValue((robot, from, to), out var result)) {
                    current += result;
                    return;
                }

                var before = current;
                long shortestForRobot = -1;
                foreach (var direction in directionalPathsChar[(from, to)]) {
                    current = before;
                    var fromNext = Action;
                    foreach (var toNext in direction) {
                        DoType(robot + 1, fromNext, toNext);
                        fromNext = toNext;
                    }
                    var thisPath = current - before;
                    if( shortestForRobot < 0 || thisPath < shortestForRobot) {
                        shortestForRobot = thisPath;
                    }
                }
                current = before + shortestForRobot;
                
                cache[(robot, from, to)] = shortestForRobot;
            }
            var numFrom = Action;
            foreach (var numTo in robot2In) {
                DoType(0, numFrom, numTo);
                numFrom = numTo;
            }
            //Console.WriteLine(new string(robotInput[0].ToArray()));
            //Console.WriteLine(new string(robotInput[1].ToArray()));
            if( shortest <0 || current < shortest) {
                shortest = current;
            }
        }
        var codeValue = int.Parse( new string( line).Substring(0, line.Length - 1));
        sum += shortest * codeValue;
        Console.WriteLine($"for code {codeValue}, shortest is {shortest}. current sum is {sum}");
    }
    Console.WriteLine(sum);
    
}

Part2(inputReal);
Dictionary<( char from, char to ), IReadOnlyList<IReadOnlyList<Grid.Direction>>> GetPathsByChar( char[][] grid, bool filter = false ) {
    var res = new Dictionary<( char from, char to ), IReadOnlyList<IReadOnlyList<Grid.Direction>>>();
    foreach (var path in GetPaths(grid)) {
        var from = grid[path.Key.from.I][path.Key.from.J];
        var to = grid[path.Key.to.I][path.Key.to.J];
        if (from == ' ' || to == ' ') {
            throw new Exception();
        }
        if( !filter) {
            res[(from, to)] = path.Value;
            continue;
        }
        var tmp = new List<IReadOnlyList<Grid.Direction>>(1);
        if( path.Value.All( x => x.Count <=2)) {
            tmp.Add(path.Value[0]);
            res[(from, to)] = tmp;
            continue;
        }
        foreach (var p in path.Value) {
            if (p[0] != p[^1]) {
                tmp.Add(p);
            }
        }
        res[(from, to)] = tmp;
    }
    return res;
}
Dictionary<( Grid.Position from, Grid.Position to ), IReadOnlyList<IReadOnlyList<Grid.Direction>>> GetPaths(char[][] grid) {
    var paths = new Dictionary<(Grid.Position from, Grid.Position to), IReadOnlyList<IReadOnlyList<Grid.Direction>>>();

    IReadOnlyList<IReadOnlyList<Grid.Direction>> GetPath(Grid.Position from, Grid.Position to) {
        if( grid[to.I][to.J] == ' ' || grid[from.I][from.J] == ' ') {
            return [];
        }
        if (paths.TryGetValue((from, to), out var result)) {
            return result;
        }

        if (from == to) {
            paths[(from, to)] =  [[]];
            return paths[(from, to)];
        }

        var res = new List<IReadOnlyList<Grid.Direction>>();
        if (from.J < to.J && grid.TryGoRight(from, out var right)) {
            res.AddRange(GetPath(right, to).Select(x => new[] { Grid.Direction.Right }.Concat(x).ToArray()));
        }

        if (from.J > to.J && grid.TryGoLeft(from, out var left)) {
            res.AddRange(GetPath(left, to).Select(x => new[] { Grid.Direction.Left }.Concat(x).ToArray()));
        }

        if (from.I < to.I && grid.TryGoDown(from, out var down)) {
            res.AddRange(GetPath(down, to).Select(x => new[] { Grid.Direction.Down }.Concat(x).ToArray()));
        }

        if (from.I > to.I && grid.TryGoUp(from, out var up)) {
            res.AddRange(GetPath(up, to).Select(x => new[] { Grid.Direction.Up }.Concat(x).ToArray()));
        }
        paths[(from, to)] = res;
        return paths[(from, to)];
    }

    foreach (var from in AllPositions(grid)) {
        foreach (var to in AllPositions(grid)) {
            GetPath(from, to);
        }
    }
    return paths;
}
IEnumerable<Grid.Position> AllPositions(char[][] grid) {
    for (int i = 0; i < grid.Length; i++) {
        for (int j = 0; j < grid[0].Length; j++) {
            yield return new Grid.Position(i, j);
        }
    }
}

public class RecursiveChar {
    public IReadOnlyList<char> Prefix { get; init; }
    public List<RecursiveChar> Next { get; init; }

    public List<List<char>> ToExplicitList() {
        var res = new List<List<char>>();
        if (Next.Count == 0) {
            res.Add(Prefix.ToList());
        }
        foreach (var next in Next) {
            foreach (var nextList in next.ToExplicitList()) {
                res.Add(Prefix.Concat(nextList).ToList());
            }
        }

        return res;
    }
}

