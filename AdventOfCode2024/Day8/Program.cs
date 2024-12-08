﻿// See https://aka.ms/new-console-template for more information


using Template;

const string inputReal = @"...............e...........j6.....................
.....1...............................t.....i......
.....4.......3..............x..tL......m..........
.......L.....................Dxj..................
4....X..................F.....................m...
.............4.......x....F........k..............
......3...................t..........i.........Z..
....L..................y.....F..e.....Z...........
X.............1........C..........i...D...........
........4.....................D.....k.X...m.......
...1...............D........e......6..............
...3.Y...................................m8.......
..OL.........................x....Z....g..........
....3......5.........................6j...........
...................J..5r.F..k...y.................
.......................................Z..a.......
...........................5........j.........a.u.
...p..............Y....X..........................
...O.........................kd...................
........................t.................i.......
..................J..............u...........z....
.O.....9.............J..............p..u..........
.....9............................................
l...6.....1........e......I................a......
...................................az.............
........M.......J...................gI....z.......
.......Y...l...........p......g....d.......W......
........5l....9................d.....g............
.A....9.l.Y............I..............B.......s...
..................................K.....B.........
....M.............7.......8..........h.....K......
.......0f...oc..............G...d7.......z...s..yW
...M........0...........Gf.....................T..
................r......G..................w....h..
...........cP................G.8.R..............T.
.................A.............N............u..B..
..H.c..b............................K...CB.....y..
......c...bP...2............7..K..................
......b.o....0.......P.............s........h.R...
......2........f..S........8.....................R
U....2..............p..............7..............
.HE..b......A.............N..............w....C...
................................N.............w...
.........E...........M................W.......T...
......E...rS2...........W....................N....
.....SP..n.....r..0...............................
.....H..............A............................w
..........n..U....................s...............
..n.So.....U................f.....................
Ho................................................";
const string inputTest = @"............
........0...
.....0......
.......0....
....0.......
......A.....
............
............
........A...
.........A..
............
............";

void Part1(string input) {
    var lines = input.Split(Environment.NewLine);
    int maxX = lines[0].Length;
    int maxY = lines.Length;
    bool IsInBounds(int x, int y) => x >= 0 && x < maxX && y >= 0 && y < maxY;
    var antennas = new Dictionary<char, List<(int x, int y)>>();
    for (int i = 0; i < lines.Length; i++) {
        for (int j = 0; j < lines[i].Length; j++) {
            if( lines[i][j] == '.') {
                continue;
            }
            if(!antennas.TryGetValue(lines[i][j], out var list)) {
                list = new List<(int x, int y)>();
                antennas[lines[i][j]] = list;
            }
            list.Add((i, j));
        }
    }

    var antinodes = new HashSet<(int x, int y)>();
    foreach (var antenna in antennas) {
        Console.WriteLine($"Antenna {antenna.Key}");
        // for each pair of antennas
        for (int i = 0; i < antenna.Value.Count; i++) {
            for (int j = i + 1; j < antenna.Value.Count; j++) {
                var a = antenna.Value[i];
                var b = antenna.Value[j];
                var vector = (a.x - b.x, a.y - b.y);
                var antinode1 = (a.x + vector.Item1, a.y + vector.Item2);
                if( IsInBounds(antinode1.Item1, antinode1.Item2) ) {
                    antinodes.Add(antinode1);
                }
                var antinode2 = (b.x - vector.Item1, b.y - vector.Item2);
                if( IsInBounds(antinode2.Item1, antinode2.Item2) ) {
                    antinodes.Add(antinode2);
                }
            }
        }
    }
    Console.WriteLine(antinodes.Count);
}

void Part2(string input) {
    var lines = input.Split(Environment.NewLine);
    int maxX = lines[0].Length;
    int maxY = lines.Length;
    bool IsInBounds(int x, int y) => x >= 0 && x < maxX && y >= 0 && y < maxY;
    var antennas = new Dictionary<char, List<(int x, int y)>>();
    for (int i = 0; i < lines.Length; i++) {
        for (int j = 0; j < lines[i].Length; j++) {
            if( lines[i][j] == '.') {
                continue;
            }
            if(!antennas.TryGetValue(lines[i][j], out var list)) {
                list = new List<(int x, int y)>();
                antennas[lines[i][j]] = list;
            }
            list.Add((i, j));
        }
    }

    var antinodes = new HashSet<(int x, int y)>();
    foreach (var antenna in antennas) {
        Console.WriteLine($"Antenna {antenna.Key}");
        // for each pair of antennas
        for (int i = 0; i < antenna.Value.Count; i++) {
            for (int j = i + 1; j < antenna.Value.Count; j++) {
                var a = antenna.Value[i];
                var b = antenna.Value[j];
                var vector = (a.x - b.x, a.y - b.y);
                var vectorGcd = Arithmetic.gcd(vector.Item1, vector.Item2);
                vector = ((int, int))((int) (vector.Item1 / vectorGcd), vector.Item2 / vectorGcd);
                var antinode = (a.x, a.y);
                while( IsInBounds(antinode.Item1, antinode.Item2) ) {
                    antinodes.Add(antinode);
                    antinode = (antinode.Item1 + vector.Item1, antinode.Item2 + vector.Item2);
                }
                antinode = (b.x, b.y);
                while( IsInBounds(antinode.Item1, antinode.Item2) ) {
                    antinodes.Add(antinode);
                    antinode = (antinode.Item1 - vector.Item1, antinode.Item2 - vector.Item2);
                }
            }
        }
    }
    Console.WriteLine(antinodes.Count);
}

Part2(inputReal);