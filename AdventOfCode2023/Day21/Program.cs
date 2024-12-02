// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Collections.Specialized;
using System.Text;
using Template;

Console.WriteLine("Hello, World!");

const string inputReal = @"...................................................................................................................................
....#.............#...............#.......#..........#..................##..........#.....#..................##...#...#..........#.
...............#......#........#.......#........#.........................#.....#........#........#...#....#....#.........#....##..
..#........#........#.##........#....#...#.....................................#................#.#...#..#....................#....
...................#.............#........#.....#........#.........................#.......#...#.........#...........#...........#.
...##.#....#...#.#..#....#.......##..#.....#..#..#......#.......#.........#.#.......#....#........#.....#.#...#................#...
............#....#.........#.#..............##..................................#.#.......#.#..........#...#..#.#......##..#.......
..................#...##............#.....#.....#.....#......................#..#.............................#....##..#...#.#.....
............#.............#.........#........................##..............#.#....#.............#..........#.....#...............
................#..#...##........#...#............#..................#.........#.....#..............#....#................#........
.#...#...#..#.#...#............#....#..#.#.........#............#.#.#..#..................#.##....#.............#..................
....#..#....#......#..#..##...#.#..#...##.........................#...................#..........#..#.......#...##.....#.....#.....
....................#..........................##................................#.....................#................#.....#.##.
..............#..............#..#..#.......#....#....................................#.........#..........#.#...............#.##...
........#......#.#.........#.......#..........#..................................................................#........#..#..#..
.................#.......##.......##......#..................#..#.......#....................#....#............#.......#.......#.#.
.....##.......#......#...#.#....#..#.................#.#....#.....#.............................#..#.........#.#.................#.
.......................#.....#...##...##..................................#....................##....##..........#..#..............
.#.......#....##.....#........#..............................#.....#....#.....................#........#..#..#.......#.#....#....#.
....#..#............#.........#...........................#.........##....#..#...................#..............#........#......##.
......##.................#..#.....................#...........................#.........................#...................#......
.....#...##.........#........#.##....###..................#........#..........................#.####................#.....#...#....
.#....#...#........#....#.............#................#.................##...#....#................#..#...#.....#............#....
....##.#.#.....#......#.......##.....#..........#........#..............#...#....#.................#.....#....#....................
.....#..............#.##..#.......#..........##..........................#.#.........#..........#....##....#.........#.#...........
.....#..#........#.#..........#...#.................#...........#.....#.........................#.#............#...................
.......#...........#..........#......................#........................##.....##............#........#..................##..
....#........................................#..#.....................#...#.#...#......................#...#....#................#.
....#.##......#........#.....................#.........#...................#...#....#.#..............###..................###......
..#...........#.....#....#..#.#............#...........#........#.....#.#................................#.......##....##..........
...##.###.....................#............#.....#..#.#..............##..#.##..#.....#...................#.#......#....#...........
.##....#............#....#.............#...#.#.............#..##.............#......................##.##..................#..#....
...#.....##.........#..##..............#..#........##..#.#................#...#.#.#....#..................#..............#.........
..........#....#.#.....#.................#...#............#.#......#...........#..........##..#...............#...#...##..#.#......
..............#.....................#....#..#.##...#.......#.#..#.....#..................#................#........................
......#.#.......#.....#...........##.................#......#........#.#........#..........#..##.........#...#.......#..#..........
........................#..........#..#..................#...................#..#..##...##..#...................#.............#....
...............#...#......................#....#...#..............##....#......#......#...#..#.....................................
......#...#...###..#..#...................#...#.#............#......#...##....#.........#..#.....#.........#.#........##...........
.#...#.........................##..##................#.....##.#...#........#.....#..#....##.........#..................#..#........
..#......#.........#..........##..#......##.#................................................#.......#.........................#.#.
......#....#..#.#..#.............#..............#.........#........#.....#.#..#......#.#.........................#..............#..
.........................................#........#..................#...##.......#..........#........#..........#..#..............
..#..........#............................#...#.....#....#..................#......................#.#..........#.##......#...#....
...........................................#.....#..#....#........#.....#........#......#...#...................................#..
..#..#...#.#..................#.#.............#..........#....#.....#......#......##.#..#...#.##....#....................#.....#...
..#..##..........................#........#....#..........#........#..........#..#.#..............#..#......................#.#....
....#...#.#.#..........#......................................#.......#...................##..#..#..................#.....#........
............................#............##.#..............#.......#.#...#....#.........#....#......#........................#.....
..#.........#...............#.......#....#..........#.....#.................#..#...##.#......................................#.....
.......#...#.................#..................#......#....#..##...#.........#.#.#..........#...##..#.#...................#.......
.........................#.............#....#...#.#.#....#.....#...............#........#.#...#..#..........#............#.........
.......##.............##............#..###..#.#..#..##....#...#......##..#...#........#....#..#..........#..#..#..........#........
..#..............#..##.......#...#........##.......................#..................#...........##........#.#..............#.....
.#...#.............................#.#.......#....................#.......#..........#...................#....#...##...............
..................####.#............###.....#.##..#...............#.............#..#..........#...............................#..#.
.....................#....#.......#......#......#......#..................#..#....#..........#....#..............#..#..............
.............#.#.##..#..#.....#.....##........##..#.#.........#......#..#.........##......#........#.........#...#...#.............
.#..........#..#.........#...#..##.........#........###......#....##...........#......#.#......................#.....#.............
..#.........##.#..#.#..........#.............................#.............##......#..#.............#.....#...#....#...............
.#......................#.....................###..#.#.....#..........#..#.#.#....#.......#..#.........#...........................
..........#......#....#..#....##..........#..........#.#...................#.................#....#.....#......#..........#........
.........................#.....#.....#........................#.........#.#...#............................#.....#.................
........#........#.........................##...............#.#.#......#......#......#..#.........#.....#.................#........
...............##..........#...........................#.....#....#.....#.#...................#.............#...............#......
.................................................................S.................................................................
.................##...#....#..........#..##..##..........#......#..#..............##...#.#......#......#......#..#.......#.........
..........#.........#.#...#..#....#.#.............#..#..#...........#.............#...........##.#...........#.......##............
........#............#.#..........#..##.#.#...............#.....#......#...#...#....#......#........#.............#.......#........
..........#...............#..#.................##.....#............#....###....#.............#................#...#................
.#..............#.....##.#....#...#..#.##.......................#.#....#.......#.#............#........#.....#..##...##............
.##.........#...................##.....#....#.......#.............##.......#...................#...........#.......#....#..........
............#..#...#.....#....#...........#.#......#.#..#.........#.#....#..................##............#........................
.............#..#...#....#......#......#......................#....#......###..........#..#.#..#...##....#..#......................
...#.........#..........#..#.........................##...........#......#............#..#.#.....##............#..#.#........#..#..
....#.#........##......................#.#.#.#..#.....#..#....##...#....##...#.#...#......#......................#.................
.....##..................#..........#.....##.....##..........#.#..#.......#.#...#.........#.......#..........#....#..........#.#...
...........................#..........#...#......#.#..#........#...#...............................#.#.#...#.....#..........#...##.
.....................#..##.##.....#......#.........#..##...#...............#.#.#........#..#...#...........#...#...................
..........#.........#..#.....#.......#.....###......#.....#.........#......#...............#.........#.........#...................
.......##..#..............#.........#.....#.......#...##.###...........#.#..........##.........................................#...
..#.....#..................#.#..........#..#..##....#...............#..............#.........##.........###.#...........#....##....
.#....#.....#.................#...#..........#.........#....#..............#.........##......#...#..........#........#.#.......#...
..............#.......................##.......##.......#..#.........#.....#....................................................#..
...#..#......#.............#....##..........#.#.......#...............#................###...#....#......#.........#.....#.....#...
....#..........#..........#..........#.....#..............#.......##......................#..#.#...............................#...
.#......#.....................................##.#..........................#.....#.#..#.#..........##.......................#...#.
......#........#.............#...........#.#............#.#.#...................#.##......#.#...................#....#..#..#.......
.#.........##.....#.............#...........#.......#.......#.....##..###.....#...........#.......................#.#..............
....##.........#.............................#.....##........#......#........#................#...#......................#.........
..................#...............##...............##.....#..#.#........#.....#.....#........#...#..#.........#.#.....#......#.#...
..................#.............##..#...............#....#.........##..#..........#......#....#.................##..#..#......#..#.
.........###.......#................#....##.....#...#...........#.............................#...#................#...............
...#......#...#...#...#...................#....#.#......#..#..#...#....#..#....................#..............#.................#..
......................#.............##..#....#...#..............#...................#..#.......#..............###................#.
..#........#.#............#..............#.......##......................#..............#..................#..#..#...........#.....
.#........#..............................#..........................................#..........#.......#.............#.#.......#...
.............#..#....#......#.......#.#.................................##...............................#....#......#.............
.#.#...#...#....#...#......#................#..#.......#..#.##..............#...........#....#.......#............#....#.........#.
...#.............#....#............................#........##.........##..........#..............................#.....#.......#..
....#......#....#......#...................#.........#.......##.......................#..................###........###.......#....
..........#...#......#........#..........#.........#.......#....#............#.....##......................#...........#..##..#.#..
.###.#.##......#.#........................#.#..#...................#.......#....#................##...#..#...#..#..#.###....#......
.....#.#......................................#.............#......#............................#..................................
..................#...............##.................#.........................#.................#.......#..##.#..##.....#..#......
...........#.........#.#...#....#.......................#.........#............#.#...#............##............#..................
.....#........#.............#..#..................#..#......#...#.#.......#.....................#..................................
..................#.#..............##..........#..........##....................................#.#............#.#.....#........#..
.....#.#.##....#..............#..........................#......#....#...#.....................................#...#..#.#.....#....
....#.#.........##.....................#...........................#......#.......#........#.#.#..#..#.......#....#..#......#...#..
............#.......#.............#......#...............#......#.##.....#..#......................#....#.....#...........#..##....
...#...#....#..#...##.......#.....#.....................##.....#..............#.............#...#....#..##.#....#........###..#....
.....#..............#....#.......#..........................#..........................#..##.....#...##................##..........
...#........#..#.#............##............#.........###....#.#.....#....#.............##................#.......#..##.......#.#..
...........#.........#..#...........#...................#......#.....#.....................#...........#.....#.....................
...#..#...##...............#..................#.............##......##...............#...#............#.........#..#...#.......#...
......#...........#............##.#.#...#...............#..#......##...........................#...#..#.#.......#.....#.........##.
...........#.#..#................#.......#......#............#..#.....#...............#....#.......#.#..#.#......#....#............
...#..............................................................#................#.....#.........................................
.................##.....................#.#....#..............#....................................#..............#.#..............
.............##.............#..##..................#..............#............#.................#........................#.#......
...........................#.....#..#..##.....##............#..#.......................#.....#..#.....#..#.....#........#....#.....
..........#.................#........#.......................................#.#...#..###...###.#...........#...#..................
..#....#.........#....#.........#....#.....#...................#............#....#.......#...#......#......#.#..........##..#......
...#........................#..#...........#...##..........................###................#.#.......#..................#.......
.......#.#............#.......#.....#.............................#.........#......#......................#........#...#.......#...
.#.#..#.........................#..........#......................................#...........#..#...............#......##.........
...#..............#......#.##....##.#...#..........##............................#.#.#........#.#........#....##.............#.....
....................#...............#..#........#...........................................##..........#.#.....#....#.#...#.......
.......................#........##..............#........#....................#.......#...#....#...........##........#....#.....#..
...................................................................................................................................";
const string inputTest = @"...........
.....###.#.
.###.##..#.
..#.#...#..
....#.#....
.##..S####.
.##..#...#.
.......##..
.##.#.####.
.##..##.##.
...........";

void Part1(string input) {
    var grid = input.Split(Environment.NewLine).Select(l=>l.ToCharArray()).ToArray();
    var reached = new HashSet<(int i, int j)>();

    var start = grid.FindCell('S');
    reached.Add(start);
    grid[start.i][start.j] = '.';
    for (int k = 0; k < 64; k++)
    {
        var newReached = new HashSet<(int i, int j)>();
        foreach (var c in reached)
        {
            if( grid.HasCell(c.i + 1, c.j) && grid[c.i + 1][c.j] == '.') {
                newReached.Add((c.i + 1, c.j));
            }
            if( grid.HasCell(c.i - 1, c.j) && grid[c.i - 1][c.j] == '.') {
                newReached.Add((c.i - 1, c.j));
            }
            if( grid.HasCell(c.i, c.j + 1) && grid[c.i][c.j + 1] == '.') {
                newReached.Add((c.i, c.j + 1));
            }
            if( grid.HasCell(c.i, c.j - 1) && grid[c.i][c.j - 1] == '.') {
                newReached.Add((c.i, c.j - 1));
            }
        }
        reached = newReached;
    }
    Console.WriteLine(reached.Count);
    
}

void Part2(string input) {
    var grid = input.Split(Environment.NewLine).Select(l=>l.ToCharArray()).ToArray();

    var start = grid.FindCell('S');
    grid[start.i][start.j] = '.';

    int nbLines = grid.Length;
    int nbCols = grid[0].Length;

    int toTileI(int i) {
        return (  i / nbLines ) - ( i< 0 ? 1 : 0);
    }
    int toTileJ(int j) {
        return (  j / nbCols ) - ( j< 0 ? 1 : 0);
    }
    int startI( int tileI) {
        return tileI * nbLines;
    }
    int startJ( int tileJ) {
        return tileJ * nbCols;
    }
    char Get(int i, int j) {
        if (i < 0) {
            i += nbLines * (Math.Abs(i / nbLines) + 1);
        }
        if (j < 0) {
            j += nbCols * (Math.Abs(j / nbCols) + 1);
        }

        return grid[i % nbLines][j % nbCols];
    }
    bool CanGo(int i, int j) {
        return Get(i,j)== '.';
    }

    long Score(int nbSteps)
    {

        var reached = new HashSet<(int i, int j)>();
        reached.Add(start);
        for (int k = 0; k < nbSteps; k++)
        {
            var newReached = new HashSet<(int i, int j)>();
            foreach (var c in reached)
            {
                if (CanGo(c.i + 1, c.j))
                {
                    newReached.Add((c.i + 1, c.j));
                }

                if (CanGo(c.i - 1, c.j))
                {
                    newReached.Add((c.i - 1, c.j));
                }

                if (CanGo(c.i, c.j + 1))
                {
                    newReached.Add((c.i, c.j + 1));
                }

                if (CanGo(c.i, c.j - 1))
                {
                    newReached.Add((c.i, c.j - 1));
                }
            }
           // Console.WriteLine(newReached.Count - reached.Count);
            Console.WriteLine(newReached.Count(c => (c.i >= 0 && c.j >= 0 && c.i < nbLines && c.j < nbCols)));
            reached = newReached;
        }

        /*var minI = startI(toTileI(reached.Min(c => c.i)));
        var maxI = startI(toTileI(reached.Max(c => c.i))) + nbLines;
        var minJ = startJ(toTileJ(reached.Min(c => c.j)));
        var maxJ = startJ(toTileJ(reached.Max(c => c.j))) + nbCols;
        for (int i = minI; i < maxI; i++)
        {
            var sb = new StringBuilder();
            for (int j = minJ; j < maxJ; j++)
            {
                if( i == start.i && j == start.j) {
                    sb.Append('S');
                    continue;
                }
                sb.Append(reached.Contains((i, j)) ? 'O' : Get(i,j));
            }
            Console.WriteLine(sb.ToString());
        }*/
        
        return reached.Count;
    }

    foreach (var steps in new int[]{/*10,50/*,100/*,500/*,1000,5000*/200})
    {
        Console.WriteLine(Score(steps));
        //Console.WriteLine();
    }
    Console.WriteLine(grid.CountCell('.'));
    
}

void Part2b(string input, int nbRound)
{
    var grid = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();

    var start = grid.FindCell('S');
    grid[start.i][start.j] = '.';

    var reference = new GridRef(grid);
    var states = new Dictionary<(int i, int j), BaseState>();
    BaseState stable1 = null;
    BaseState stable2 = null;
    State NewState(int tileI, int tileJ) {
        return new State {
            Reference = reference, States = new bool[reference.NbCols * reference.NbLines], Count = 0, TileI = tileI, TileJ = tileJ
        };
    }

    BaseState current = NewState(0, 0);
    current.States[start.i * reference.NbCols + start.j] = true;
    for (int i = 0; i < 150; i++)
    {
        var next = current.Next(states);
        stable1 = stable2;
        stable2 = next;
        current = next;
    }

    var someState = current.Next(states);
    if (!someState.Equals(stable1))
    {
        Console.WriteLine("Not stable");
    }

    Console.WriteLine(stable2.Count);
    Console.WriteLine(stable1.Count);

    reference.Stable1 = new StableState
        { IsStable1 = true, Count = stable1.Count, States = stable1.States, Reference = reference };
    reference.Stable2 = new StableState
        { IsStable1 = false, Count = stable2.Count, States = stable2.States, Reference = reference };

  
    current = NewState(0,0);
    current.States[start.i * reference.NbCols + start.j] = true;
    
    states[(0,0)] = current;
    for (int i = 0; i < nbRound; i++) {
        var newStates =  new Dictionary<(int i, int j), BaseState>();
        foreach (var state in states.Values) {
            var next = state.Next(states);
            newStates[(next.TileI, next.TileJ)] = next;
            if( !states.ContainsKey((next.TileI - 1, next.TileJ)) && next.HaveUp() ) {
                newStates[(next.TileI - 1, next.TileJ)] = NewState(next.TileI - 1, next.TileJ);
            }
            if( !states.ContainsKey((next.TileI + 1, next.TileJ)) && next.HaveDown() ) {
                newStates[(next.TileI + 1, next.TileJ)] = NewState(next.TileI + 1, next.TileJ);
            }
            if(!states.ContainsKey((next.TileI, next.TileJ - 1)) && next.HaveLeft() ) {
                newStates[(next.TileI, next.TileJ - 1)] = NewState(next.TileI, next.TileJ - 1);
            }
            if( !states.ContainsKey((next.TileI, next.TileJ + 1)) && next.HaveRight() ) {
                newStates[(next.TileI, next.TileJ + 1)] = NewState(next.TileI, next.TileJ + 1);
            }
        }
        states = newStates;
        if (i % 10 == 0)
        {
            Console.WriteLine($"i={i}");
        }
    }
    Console.WriteLine(states.Values.Sum(s=>s.Count)); 
    Console.WriteLine(states.Values.Count); 
    /*foreach (var state in states.OrderBy( kv=>kv.Key)) {
        Console.WriteLine(state.Value);
    }*/
}

void Part2c(string input, int nbRound)
{
    var grid = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();

    var start = grid.FindCell('S');
    grid[start.i][start.j] = '.';
    
    var reference = new GridRef(grid);
    var states = new Dictionary<(int i, int j), BaseState>();
    BaseState stable1 = null;
    BaseState stable2 = null;
    State NewState(int tileI, int tileJ) {
        return new State {
            Reference = reference, States = new bool[reference.NbCols * reference.NbLines], Count = 0, TileI = tileI, TileJ = tileJ
        };
    }

    BaseState current = NewState(0, 0);
    current.States[start.i * reference.NbCols + start.j] = true;
    for (int i = 0; i < 150; i++)
    {
        var next = current.Next(states);
        stable1 = stable2;
        stable2 = next;
        current = next;
    }

    var someState = current.Next(states);
    if (!someState.Equals(stable1))
    {
        Console.WriteLine("Not stable");
    }

    Console.WriteLine(stable2.Count);
    Console.WriteLine(stable1.Count);

    reference.Stable1 = new StableState
        { IsStable1 = true, Count = stable1.Count, States = stable1.States, Reference = reference };
    reference.Stable2 = new StableState
        { IsStable1 = false, Count = stable2.Count, States = stable2.States, Reference = reference };

    var cache = new Dictionary<(int i, int j), (int offset, List<BaseState>)>();
    ( int offset, List<BaseState> states) GetCacheEntry(int i, int j) {
        return cache[(i < 0 ? -1 : i> 0 ? 1 : 0, j < 0 ? -1 : j > 0?  1:0)];
    }
    void AddToCache(int i, int j, int offset, BaseState state) {
        if (!state.CanBeCached()) {
            if (Math.Abs(i) + Math.Abs(j)> ( 2 + ( i== 0 || j == 0 ? 1 : 0)))
            {
                var entry = GetCacheEntry(i, j);
                int tileToCount = (Math.Abs(i) + Math.Abs(j) - ( 2 + ( i== 0 || j == 0 ? 1 : 0))) * reference.Modulo;
                var match = offset - tileToCount - entry.offset;
                if( match<entry.states.Count && !state.Equals(entry.states[match])) {
                   Console.WriteLine($"Not matching {i},{j} {offset}");
                }
            }
            return;
        }
        i= i<0? -1 : i>0 ? 1: 0;
        j= j<0? -1 : j>0 ? 1: 0;
       
        if (!cache.TryGetValue((i, j), out var value)) {
            value = (offset, new List<BaseState>());
            cache[(i, j)] = value;
        }
        if(value.Item2.Count > 0 && value.Item2.Last().IsStable()) {
            return;
        }
        value.Item2.Add(state);
    }
    
    current = NewState(0,0);
    current.States[start.i * reference.NbCols + start.j] = true;
    states[(0,0)] = current;
    //AddToCache(current);
    for (int i = 0; i < 1500; i++) {
        var newStates =  new Dictionary<(int i, int j), BaseState>();

        void AddNewState(BaseState newState) {
            if( newStates.ContainsKey((newState.TileI, newState.TileJ))) {
                return;
            }
            newStates[(newState.TileI, newState.TileJ)] = newState;
            AddToCache(newState.TileI,newState.TileJ,i,newState);
        }
        foreach (var state in states.Values) {
            if( !states.ContainsKey((state.TileI - 1, state.TileJ)) && state.HaveUp() )
            {
                BaseState upState = NewState(state.TileI - 1, state.TileJ);
                upState = upState.Next(states);
                AddNewState(upState);
            }

            if (!states.ContainsKey((state.TileI + 1, state.TileJ)) && state.HaveDown())
            {
                BaseState downState = NewState(state.TileI + 1, state.TileJ);
                downState = downState.Next(states);
                AddNewState(downState);
            }

            if(!states.ContainsKey((state.TileI, state.TileJ - 1)) && state.HaveLeft() )
            {
                BaseState leftState = NewState(state.TileI, state.TileJ - 1);
                leftState = leftState.Next(states);
                AddNewState(leftState);
            }
            if( !states.ContainsKey((state.TileI, state.TileJ + 1)) && state.HaveRight() )
            {
                BaseState rightState = NewState(state.TileI, state.TileJ + 1);
                rightState = rightState.Next(states);
                AddNewState(rightState);
            }
            var next = state.Next(states);
            AddNewState( next);
            
        }
        
        states = newStates;
        if (i % 10 == 0)
        {
            Console.WriteLine($"i={i}");
        }
    }

    Trace.Assert(cache.Values.All( v=>v.Item2.Last().IsStable()));
    Console.WriteLine("cache full");
    long sum = 0;
    // count = offset + ((tileI-1) * Modulo)
    // tileI = (count - offset) / Modulo + 1

    //int maxTileIndex = (nbRound - cache.Values.Min(v => v.Item1)) / reference.Modulo + 1;

    int zeroLeftCount = nbRound - cache[(0, 0)].Item2.Count;
    BaseState StableStateAfter(BaseState state, int count) {
        return count%2 == 0 ? state : state.Next(null);
    }
   
    
    var stateZero = StableStateAfter(cache[(0, 0)].Item2.Last(), zeroLeftCount);
    var stateNonZero = stateZero.Next(null);
    sum += stateZero.Count;
    

    int LastTileIndex(int i, int j) {
        var entry = GetCacheEntry(i, j);
        return (nbRound - entry.offset -1) / reference.Modulo + 1 + (i == 0 || j == 0 ? 2 : 0);
    }

    int TileCount(int i, int j) {
        var entry = GetCacheEntry(i,j);
        int tileToCount = (Math.Abs(i) + Math.Abs(j) - ( 2 + ( i== 0 || j == 0 ? 1 : 0))) * reference.Modulo;
        int leftCount = nbRound - tileToCount - entry.offset -1;
        if (leftCount >= entry.Item2.Count)
        {
            return StableStateAfter(entry.Item2.Last(), leftCount - entry.Item2.Count + 1).Count;
        }

        return entry.Item2[leftCount].Count;
    }
    long StableSumLine( BaseState startState, int count) {
        var res = 0L;
        res +=  ((long)startState.Count) * ( (long)count /2);
        res += ((long)startState.Next(null).Count) * ((long)count /2);
        if (count % 2 == 1)
        {
            res += startState.Count;
        }
        return res;
    }

    long SumAxis(int i, int j)
    {
        int maxIndex = LastTileIndex(i, j);
        Console.WriteLine(maxIndex);
        var res = StableSumLine(stateNonZero, maxIndex - 2);
        res += TileCount(i * (maxIndex - 1), j * (maxIndex - 1));
        res += TileCount(i * maxIndex, j * maxIndex);

        return res;
    }

    sum+= SumAxis(0,1);//right
    sum+= SumAxis(1,0);//down
    sum+= SumAxis(0,-1);//left
    sum+= SumAxis(-1,0);//up
    
    long StableSumTriangle(BaseState startState, int baseCount) {
        long res = 0L;
        int nbDiagSameAsStart = (baseCount + 1) / 2 ;
        int nbDiagSameAsNext = baseCount / 2;
        res += (long)startState.Count * ((long)nbDiagSameAsStart * (long)nbDiagSameAsStart);
        res += (long) startState.Next(null).Count * ((long)nbDiagSameAsNext * ((long)nbDiagSameAsNext + 1));
        return res;
    }
    long SumTriangle(int i, int j) {
        int maxIndex = LastTileIndex(i,j);
        var res = StableSumTriangle(stateZero, maxIndex - 2);
        long avantDernier = TileCount( i, j*(maxIndex-1));
        long dernier =  TileCount(i, j*maxIndex);
        res += avantDernier * ((long)maxIndex - 1);
        res += dernier * (long)maxIndex;
        return res;
    }
    sum+= SumTriangle(1,1);//right down
    sum+= SumTriangle(1,-1);//right up
    sum+= SumTriangle(-1,-1);//left up
    sum+= SumTriangle(-1,1);//left down
    
    
    
    //Console.WriteLine(BaseState.PrintStates(states));
    Console.WriteLine(states.Values.Sum(s=>s.Count)); 
    Console.WriteLine(states.Values.Count); 
    
    Console.WriteLine(sum);
    /*foreach (var state in states.OrderBy( kv=>kv.Key)) {
        Console.WriteLine(state.Value);
    }*/
}


//Part2c(inputTest,1000);
Part2c(inputReal,26501365);

public class GridRef
{
    public char[][] Grid;

    public GridRef(char[][] grid)
    {
        Grid = grid;
        NbLines = grid.Length;
        Trace.Assert(grid[0].Length == NbLines);
        MaxCount = grid.CountCell('.');
    }

    public int NbLines { get; }
    public int Modulo =>NbLines;
    public int NbCols => NbLines;
    public int MaxCount { get; }
    public bool HasCell( int i, int j) => i>=0 && i<NbLines && j>=0 && j<NbCols;
    public bool CanGo(int i, int j) => HasCell(i, j) && Grid[i][j] == '.';
    public char Get(int i, int j) => Grid[i][j];

    
    public string GetLine(int i) {
        return new string(Grid[i]);
    }

  
    public StableState Stable1 { get; set; }
    public StableState Stable2 { get; set; }
}

public abstract class BaseState : IEquatable<BaseState> {
    public GridRef Reference { get; set; }
    public int TileI { get; set; }
    public int TileJ { get; set; }
    public bool[] States { get; set; }
    public int Count { get; set; }

    public abstract bool IsStable();

    public bool CanBeCached()
    {
        if (TileI == 0 && TileJ == 0)
        {
            return true;
        }

        if (TileI == 0)
        {
            return Math.Abs(TileJ) == 3;
        }
        if (TileJ == 0)
        {
            return Math.Abs(TileI) == 3;
        }
        return TileI >= -1 && TileI <= 1 && TileJ >= -1 && TileJ <= 1;
    }

    public virtual bool HaveUp()
    {
        for (int i = 0; i < Reference.NbCols; i++) {
            if( States[i]) return true;
        }

        return false;
    }
    public virtual bool HaveDown()
    {
        for (int i = 0; i < Reference.NbCols; i++) {
            if( States[States.Length - Reference.NbCols + i]) return true;
        }

        return false;
    }
    public virtual bool HaveLeft()
    {
        for (int i = 0; i < Reference.NbLines; i++)
        {
            int pos = i*Reference.NbCols;
            if( States[pos]) return true;
        }

        return false;
    }
    public virtual bool HaveRight()
    {
        for (int i = 0; i < Reference.NbLines; i++)
        {
            int pos = i*Reference.NbCols;
            if( States[pos+Reference.NbCols-1]) return true;
        }

        return false;
    }
    public void SetMyUp(bool[] states)
    {
        for (int i = 0; i < Reference.NbCols; i++) {
            states[i] = States[States.Length - Reference.NbCols + i];
        }
    }

    public void SetMyDown(bool[] states)
    {
        for (int i = 0; i < Reference.NbCols; i++) {
            states[States.Length - Reference.NbCols + i] = States[i];
        }
    }

    public void SetMyRight(bool[] states)
    {
        if( States[0]) {
            states[Reference.NbCols-1] = true;
        }
        if( States[^Reference.NbCols]) {
            states[States.Length-1] = true;
        }
        for (int i = 1; i < Reference.NbLines-1; i++) {
            int pos = i* Reference.NbCols;
            states[pos+Reference.NbCols-1] = States[pos];
        }
    }

    public void SetMyLeft(bool[] states) {
        if( States[Reference.NbCols-1]) {
            states[0] = true;
        }
        if( States[States.Length - 1]) {
            states[States.Length-Reference.NbCols] = true;
        }
        for (int i = 1; i < Reference.NbLines-1; i++) {
            int pos = i*Reference.NbCols;
            states[pos] = States[pos+Reference.NbCols-1];
        }
    }

    public abstract BaseState Next(Dictionary<(int i, int j), BaseState> previousStates);

    public bool Equals(BaseState? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        if( Count != other.Count) return false;
        for (int i = 0; i < States.Length; i++)
        {
            if( States[i] != other.States[i]) return false;
        }
        return true;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return Equals((BaseState)obj);
    }

    public override int GetHashCode()
    {
        unchecked { 
            int hash = 17;
            for(int index = 0; index < States.Length; index++) {
                hash = hash * 23 + States[index].GetHashCode();
            }
            return hash;
        }
    }

    public static string PrintStates(IDictionary<(int tileI, int tileJ), BaseState> states)
    {
        var reference = states.Values.First().Reference;
        var sb = new StringBuilder();
        int minI = states.Keys.Min(k => k.tileI);
        int maxI = states.Keys.Max(k => k.tileI);
        int minJ = states.Keys.Min(k => k.tileJ);
        int maxJ = states.Keys.Max(k => k.tileJ);
        string lineSep = new string(Enumerable.Repeat('*', (reference.NbCols + 1) * (maxJ - minJ + 1) + 1).ToArray());
        for (int i = minI; i <= maxI; i++) {
            sb.AppendLine(lineSep);
            for (int k = 0; k < reference.NbLines; k++) {
                for (int j = minJ; j <= maxJ; j++) {
                    sb.Append('*');
                    if (states.TryGetValue((i, j), out var state)) {
                        sb.Append(state.GetLine(k));
                    }
                    else {
                        sb.Append(reference.GetLine(k));
                    }
                }

                sb.Append('*');

                sb.Append('\n');
            }
        }
        sb.AppendLine(lineSep);
        return sb.ToString();
    }

    public string GetLine(int i) {
        var sb = new StringBuilder();
        for (int j = 0; j < Reference.NbCols; j++) {
            if( States[i*Reference.NbCols + j]) {
                sb.Append('O');
            } else {
                sb.Append(Reference.Get(i, j));
            }
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{TileI},{TileJ}");
        for (int i = 0; i < Reference.NbLines; i++) {
            sb.AppendLine(GetLine(i));
        }
        return sb.ToString();
    }
}

public class StableState : BaseState
{
    public bool IsStable1 { get; set; }

    public override BaseState Next(Dictionary<(int i, int j), BaseState> previousStates) {
        return IsStable1 ? Reference.Stable2.Clone(TileI, TileJ) : Reference.Stable1.Clone(TileI, TileJ);
    }

    public override bool IsStable()
    {
        return true;
    }

    public override bool HaveUp()
    {
        return true;
    }

    public override bool HaveDown()
    {
        return true;
    }

    public override bool HaveLeft()
    {
        return true;
    }

    public override bool HaveRight()
    {
        return true;
    }
    public StableState Clone( int tileI, int tileJ) {
        return new StableState { IsStable1 = IsStable1, Count = Count, States = States, Reference = Reference, TileI = tileI, TileJ = tileJ };
    }
}
public class State : BaseState{
    public override bool IsStable()
    {
        return false;
    }

    public override BaseState Next(Dictionary<(int i, int j), BaseState> previousStates)
    {
        var sb = new bool[States.Length];
        if (previousStates.TryGetValue((TileI - 1, TileJ), out var up))
        {
            up.SetMyUp(sb);
        }

        if (previousStates.TryGetValue((TileI + 1, TileJ), out var down))
        {
            down.SetMyDown(sb);
        }

        if (previousStates.TryGetValue((TileI, TileJ - 1), out var left))
        {
            left.SetMyLeft(sb);
        }

        if (previousStates.TryGetValue((TileI, TileJ + 1), out var right))
        {
            right.SetMyRight(sb);
        }

        for (int k = 0; k < States.Length; k++)
        {
            if (!States[k]) continue;
            int i = k / Reference.NbLines;
            int j = k % Reference.NbLines;
            if (Reference.CanGo(i + 1, j))
            {
                sb[k + Reference.NbLines] = true;
            }

            if (Reference.CanGo(i - 1, j))
            {
                sb[k - Reference.NbLines] = true;
            }

            if (Reference.CanGo(i, j + 1))
            {
                sb[k + 1] = true;
            }

            if (Reference.CanGo(i, j - 1))
            {
                sb[k - 1] = true;
            }
        }

        var count = sb.Count(b => b);
        /*if (Reference.Stable1 != null) {
            if (count == Reference.Stable1.Count) return Reference.Stable1.Clone(TileI, TileJ);
            if (count == Reference.Stable2.Count) return Reference.Stable2.Clone(TileI, TileJ);
        }*/
        /*for(int i = 1; i < sb.Length; i++) {
            if (sb[i] && sb[i - 1])
            {
                throw new ArgumentException();
            }
        }*/
       
        var res = new State
            { Reference = Reference, States = sb, Count = count, TileI = TileI, TileJ = TileJ };
        
        if (Reference.Stable1 != null) {
            if (res.Equals(Reference.Stable1))
            {
                return Reference.Stable1.Clone(TileI, TileJ);
            }

            if (res.Equals(Reference.Stable2))
            {
                return Reference.Stable2.Clone(TileI, TileJ);
            }
        }

        return res;
    }
}