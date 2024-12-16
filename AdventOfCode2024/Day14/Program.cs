﻿// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");// See https://aka.ms/new-console-template for more information


const string inputReal = @"p=36,69 v=61,39
p=26,89 v=85,12
p=45,27 v=25,-53
p=99,30 v=-75,-86
p=17,98 v=-10,66
p=49,46 v=-43,-24
p=3,26 v=-69,-76
p=15,69 v=-16,29
p=28,11 v=67,-32
p=74,62 v=1,-31
p=38,34 v=-89,77
p=90,78 v=-69,-18
p=7,54 v=90,39
p=51,5 v=-55,-22
p=90,16 v=-93,81
p=34,2 v=-86,88
p=33,47 v=-95,83
p=46,69 v=-49,-87
p=90,49 v=84,63
p=66,77 v=68,12
p=67,69 v=-24,-93
p=19,74 v=-37,-94
p=26,63 v=21,-67
p=4,62 v=-87,3
p=78,19 v=-12,12
p=51,16 v=-38,40
p=89,52 v=-17,10
p=77,13 v=-57,-39
p=41,98 v=46,32
p=37,70 v=-49,-4
p=100,32 v=-38,70
p=39,1 v=3,91
p=12,19 v=2,11
p=24,83 v=85,-24
p=22,59 v=82,6
p=86,8 v=14,-5
p=54,91 v=6,15
p=1,15 v=66,-6
p=87,47 v=-38,76
p=92,66 v=26,92
p=27,30 v=-81,-20
p=91,85 v=78,-95
p=47,18 v=40,77
p=28,16 v=82,31
p=20,57 v=-74,3
p=97,0 v=-81,-35
p=17,46 v=-50,-51
p=14,98 v=3,45
p=54,50 v=-52,-14
p=83,50 v=47,83
p=5,78 v=-4,-36
p=81,24 v=-60,-76
p=80,20 v=96,-79
p=79,17 v=-54,94
p=58,4 v=-18,-22
p=34,13 v=21,74
p=16,48 v=88,-60
p=99,2 v=-56,45
p=4,45 v=-29,47
p=85,36 v=38,-46
p=92,26 v=-75,67
p=48,81 v=-91,77
p=2,88 v=5,-58
p=91,46 v=-44,-57
p=50,98 v=49,-5
p=76,48 v=-42,-20
p=52,35 v=26,3
p=65,97 v=70,26
p=83,49 v=63,-93
p=33,12 v=-95,57
p=52,61 v=-76,3
p=58,40 v=-73,43
p=79,65 v=-82,3
p=82,31 v=-66,-66
p=42,85 v=-3,85
p=59,97 v=-79,25
p=15,82 v=-56,-8
p=99,33 v=32,87
p=4,69 v=81,-54
p=57,82 v=-49,45
p=30,79 v=99,43
p=56,10 v=-29,3
p=37,53 v=64,66
p=8,27 v=48,67
p=19,49 v=-81,-3
p=9,6 v=-1,-55
p=15,80 v=-62,92
p=58,50 v=-76,10
p=86,87 v=90,-91
p=68,36 v=-43,95
p=71,21 v=-36,34
p=21,69 v=76,-87
p=50,55 v=43,73
p=68,100 v=-39,-98
p=20,90 v=-79,-21
p=18,40 v=-6,45
p=9,30 v=79,-6
p=49,21 v=95,94
p=33,15 v=9,41
p=46,16 v=43,87
p=13,91 v=-39,-60
p=53,0 v=41,91
p=68,51 v=74,-50
p=22,64 v=-34,34
p=83,91 v=-32,-31
p=51,96 v=-21,-48
p=48,58 v=3,20
p=32,83 v=-87,96
p=93,50 v=87,-16
p=83,72 v=-2,99
p=73,14 v=-44,-27
p=36,2 v=79,-49
p=45,75 v=92,82
p=3,68 v=-96,-44
p=6,18 v=60,-82
p=18,83 v=15,15
p=100,94 v=84,72
p=2,91 v=17,25
p=0,39 v=49,57
p=42,92 v=-46,95
p=86,32 v=-78,63
p=82,19 v=-97,-13
p=62,96 v=47,-92
p=72,64 v=7,49
p=52,29 v=34,-96
p=80,102 v=23,5
p=22,74 v=-65,42
p=16,41 v=58,-43
p=42,89 v=-38,16
p=74,68 v=4,36
p=19,63 v=79,-17
p=52,62 v=-13,83
p=30,79 v=24,22
p=88,45 v=-23,-20
p=41,52 v=-49,96
p=26,47 v=30,-87
p=1,32 v=20,-76
p=70,32 v=-18,-3
p=84,69 v=99,89
p=58,64 v=94,66
p=14,73 v=92,-3
p=26,93 v=10,-98
p=22,72 v=60,33
p=62,32 v=31,97
p=84,74 v=-57,-54
p=47,38 v=-79,-96
p=70,72 v=-78,5
p=85,30 v=29,57
p=27,67 v=79,59
p=20,25 v=-91,84
p=74,6 v=-42,-2
p=55,40 v=49,-31
p=6,80 v=-32,98
p=53,100 v=-67,-32
p=36,70 v=-42,64
p=25,37 v=-23,5
p=87,13 v=-11,51
p=80,101 v=-48,78
p=77,26 v=6,-44
p=53,81 v=-43,39
p=51,65 v=50,-49
p=27,42 v=27,93
p=86,51 v=91,98
p=16,30 v=68,-70
p=36,59 v=55,76
p=8,2 v=-99,-49
p=89,8 v=81,71
p=8,57 v=51,13
p=48,51 v=-39,-87
p=72,65 v=24,-29
p=16,81 v=94,-71
p=60,41 v=-71,13
p=29,2 v=-80,-98
p=55,4 v=-49,-99
p=94,33 v=2,-3
p=64,74 v=-54,-54
p=42,53 v=92,-30
p=89,98 v=60,-82
p=71,77 v=-33,-67
p=74,33 v=77,57
p=72,20 v=-74,80
p=12,49 v=-41,-54
p=4,59 v=-35,82
p=42,3 v=40,78
p=69,65 v=74,-47
p=37,34 v=82,-69
p=4,2 v=-27,93
p=100,48 v=-37,9
p=62,50 v=-33,-83
p=95,83 v=-3,-33
p=58,49 v=19,-20
p=41,45 v=-15,36
p=88,100 v=78,58
p=30,0 v=-65,85
p=61,60 v=25,-50
p=35,24 v=40,-66
p=81,9 v=-61,-94
p=13,24 v=13,7
p=82,9 v=-88,-16
p=16,67 v=-83,-64
p=19,1 v=-86,64
p=29,14 v=94,-69
p=29,75 v=-68,69
p=16,15 v=-59,-62
p=36,25 v=-3,41
p=22,98 v=-68,-85
p=71,72 v=-82,-4
p=33,55 v=-95,-53
p=80,94 v=82,31
p=17,33 v=39,30
p=53,4 v=-43,-45
p=65,62 v=40,-94
p=85,53 v=-63,-70
p=97,57 v=96,94
p=53,36 v=94,34
p=95,19 v=-41,-92
p=4,49 v=-96,7
p=84,97 v=-58,-56
p=99,30 v=-45,-99
p=83,80 v=69,85
p=67,99 v=93,41
p=6,80 v=5,6
p=15,64 v=53,-87
p=2,47 v=39,93
p=56,33 v=82,74
p=63,99 v=65,35
p=48,72 v=40,-31
p=24,62 v=-43,-61
p=29,81 v=-28,12
p=55,6 v=68,25
p=88,60 v=84,-87
p=50,16 v=-33,-16
p=25,82 v=76,85
p=35,14 v=52,48
p=90,65 v=-20,46
p=49,10 v=64,58
p=27,48 v=30,63
p=34,39 v=98,-99
p=54,80 v=-95,-58
p=9,96 v=-38,-51
p=22,42 v=54,-2
p=5,96 v=-72,-49
p=34,62 v=15,-74
p=20,102 v=-47,95
p=76,48 v=1,-27
p=4,101 v=19,-33
p=23,96 v=64,86
p=82,66 v=70,-7
p=62,71 v=-36,-64
p=31,94 v=67,58
p=43,62 v=58,72
p=22,0 v=-19,28
p=43,2 v=89,68
p=59,19 v=83,34
p=36,97 v=33,-15
p=27,56 v=67,63
p=30,38 v=98,-62
p=46,7 v=-57,5
p=8,52 v=8,-17
p=9,94 v=64,-43
p=55,44 v=10,17
p=92,10 v=-51,88
p=40,33 v=28,28
p=6,25 v=54,-62
p=50,86 v=28,38
p=67,54 v=-85,53
p=47,10 v=-3,-29
p=28,25 v=-56,-99
p=5,68 v=-66,-64
p=56,52 v=-60,-58
p=64,78 v=-50,60
p=61,26 v=-42,-83
p=15,41 v=-59,-86
p=42,11 v=98,-9
p=58,52 v=-73,86
p=59,32 v=49,50
p=62,16 v=-24,31
p=41,42 v=-32,75
p=23,1 v=-14,-68
p=0,47 v=87,-27
p=49,24 v=-31,50
p=90,6 v=-72,68
p=10,66 v=-10,56
p=90,46 v=81,76
p=87,44 v=87,-3
p=30,82 v=98,9
p=89,11 v=4,44
p=18,61 v=-31,-53
p=91,19 v=-9,11
p=1,10 v=14,41
p=49,21 v=-64,-26
p=74,57 v=-48,63
p=73,36 v=-42,30
p=14,87 v=90,5
p=31,4 v=-69,-19
p=15,48 v=-31,-86
p=22,92 v=90,36
p=71,85 v=-39,53
p=41,0 v=12,68
p=44,41 v=61,9
p=57,79 v=86,92
p=76,86 v=-54,-61
p=15,76 v=-56,12
p=72,75 v=56,45
p=42,34 v=27,-3
p=85,69 v=-91,36
p=37,14 v=-64,74
p=57,52 v=-94,53
p=75,32 v=-90,-85
p=52,93 v=92,-5
p=61,68 v=74,-27
p=79,39 v=-57,-63
p=54,13 v=59,9
p=99,5 v=23,-2
p=2,71 v=16,-91
p=10,89 v=91,-61
p=5,21 v=-29,-22
p=1,1 v=91,5
p=37,3 v=-19,-29
p=11,25 v=-7,-64
p=35,57 v=85,29
p=7,80 v=-89,-9
p=82,77 v=20,79
p=42,24 v=-6,14
p=80,32 v=87,-46
p=83,70 v=84,89
p=81,91 v=96,91
p=51,3 v=83,-72
p=76,98 v=50,-65
p=49,5 v=63,3
p=27,57 v=-28,3
p=67,84 v=31,-45
p=26,82 v=56,-17
p=11,100 v=-25,-22
p=82,67 v=-60,89
p=40,68 v=-49,28
p=50,21 v=98,4
p=94,81 v=-87,9
p=72,95 v=40,55
p=77,39 v=45,58
p=98,12 v=17,34
p=89,64 v=-38,-40
p=23,65 v=73,-24
p=11,29 v=20,64
p=94,0 v=29,38
p=70,44 v=-96,-33
p=36,36 v=-80,26
p=65,38 v=-61,-86
p=1,33 v=-66,-97
p=60,77 v=-27,39
p=27,23 v=-90,-64
p=83,101 v=47,-22
p=79,18 v=7,-72
p=73,28 v=-88,14
p=41,36 v=49,90
p=22,67 v=-17,7
p=100,81 v=69,-41
p=61,20 v=1,87
p=56,75 v=89,56
p=9,3 v=23,8
p=3,48 v=-96,93
p=73,11 v=29,67
p=61,24 v=-39,-52
p=68,43 v=-88,-33
p=48,88 v=-32,15
p=62,61 v=-27,59
p=56,93 v=1,-62
p=98,54 v=51,-43
p=16,68 v=42,-4
p=79,7 v=-80,-63
p=65,90 v=59,-92
p=10,64 v=25,41
p=19,81 v=-13,-61
p=1,13 v=94,-56
p=21,77 v=-56,1
p=2,36 v=-83,-28
p=81,90 v=-40,64
p=93,63 v=63,-7
p=56,40 v=86,-43
p=44,95 v=9,65
p=55,83 v=22,52
p=77,74 v=78,-21
p=68,33 v=-2,-16
p=5,57 v=8,-69
p=44,36 v=49,66
p=54,50 v=83,-80
p=24,98 v=76,98
p=87,38 v=-94,3
p=12,19 v=-1,84
p=67,94 v=19,-88
p=58,101 v=-7,-29
p=79,77 v=-91,-54
p=32,38 v=18,27
p=14,26 v=62,56
p=11,96 v=20,35
p=19,30 v=-81,10
p=17,4 v=-9,-11
p=27,60 v=-36,-62
p=87,57 v=63,-17
p=81,64 v=-11,69
p=5,58 v=-99,-80
p=95,16 v=20,-72
p=48,35 v=27,-55
p=72,22 v=-78,86
p=100,32 v=-29,90
p=46,24 v=98,-69
p=79,69 v=-24,20
p=34,36 v=61,-46
p=97,79 v=-84,-18
p=67,16 v=64,65
p=24,53 v=39,-40
p=83,93 v=-33,-51
p=68,66 v=13,-84
p=3,69 v=-69,89
p=31,42 v=67,53
p=57,5 v=48,-11
p=66,75 v=82,-69
p=31,27 v=-55,20
p=34,32 v=-55,18
p=60,44 v=98,-56
p=82,16 v=87,-52
p=35,50 v=92,-3
p=19,81 v=-68,42
p=40,56 v=-66,95
p=47,11 v=-49,-32
p=71,50 v=-48,73
p=20,33 v=-71,-63
p=26,3 v=79,-72
p=10,1 v=32,-92
p=78,94 v=-51,-35
p=2,32 v=5,-46
p=68,101 v=-12,79
p=18,91 v=30,-12
p=38,55 v=46,-80
p=20,79 v=48,-64
p=76,92 v=-88,12
p=25,50 v=81,39
p=38,90 v=30,18
p=91,71 v=84,62
p=58,22 v=68,34
p=20,50 v=94,10
p=29,6 v=79,8
p=67,29 v=-61,-72
p=55,91 v=-12,-8
p=6,101 v=-99,78
p=27,16 v=18,28
p=94,10 v=35,-42
p=22,24 v=-47,84
p=64,65 v=22,99
p=60,3 v=50,72
p=55,62 v=74,6
p=80,83 v=-35,-47
p=86,66 v=68,78
p=63,50 v=11,-79
p=87,54 v=-32,-54
p=47,36 v=98,23
p=60,4 v=19,34
p=78,12 v=-51,74
p=72,27 v=-85,-26
p=89,33 v=-36,51
p=62,57 v=-91,42
p=68,2 v=-70,-99
p=92,11 v=-78,78
p=93,84 v=63,90
p=73,31 v=-48,-66
p=73,76 v=-91,-57
p=16,18 v=51,-48
p=20,33 v=33,-89
p=79,70 v=50,-4
p=74,29 v=16,-21
p=72,15 v=19,11
p=91,22 v=75,-19
p=49,96 v=54,36
p=76,83 v=47,68
p=27,100 v=-37,5
p=59,52 v=-76,23
p=31,97 v=-62,-61
p=86,62 v=38,6
p=99,39 v=69,-99
p=43,23 v=50,-73
p=21,5 v=-65,-68
p=59,32 v=14,30
p=82,0 v=90,-25
p=32,63 v=-25,62
p=99,28 v=-35,24
p=6,88 v=78,35
p=21,39 v=94,-7
p=7,97 v=-96,5
p=73,27 v=25,-93
p=29,20 v=25,-55
p=70,71 v=10,-54
p=88,5 v=23,-45
p=84,90 v=-60,45
p=48,26 v=-64,87
p=89,5 v=-66,-42
p=88,19 v=23,-13
p=45,90 v=-59,39
p=44,90 v=6,-71
p=17,44 v=-71,50
p=1,51 v=69,79";
const string inputTest = @"p=0,4 v=3,-3
p=6,3 v=-1,-3
p=10,3 v=-1,2
p=2,0 v=2,-1
p=0,0 v=1,3
p=3,0 v=-2,-2
p=7,6 v=-1,-3
p=3,0 v=-1,-2
p=9,3 v=2,3
p=7,3 v=-1,2
p=2,4 v=2,-3
p=9,5 v=-3,-3";

var regex = new Regex(@"p=(-?\d+),(-?\d+) v=(-?\d+),(-?\d+)", RegexOptions.Compiled);
void Part1(string input, int maxX, int maxY) {
    var lines = input.Split(Environment.NewLine);
    var positions = new List<(int x, int y)>();
    var velocities = new List<(int x, int y)>();
    foreach (var line in lines) {
        var match = regex.Match(line);
        positions.Add((int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value)));
        velocities.Add((int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value)));
    }

    List<( int x, int y)> NewPositions(int nbSeconds = 100) {
        return positions
            .Select((p, i) => (mod(p.x + velocities[i].x * nbSeconds, maxX), mod(p.y + velocities[i].y * nbSeconds, maxY)))
            .ToList();
    }

    Console.WriteLine(NewPositions(1)[10]);
    Console.WriteLine(NewPositions(2)[10]);
    Console.WriteLine(NewPositions(3)[10]);
    Console.WriteLine(NewPositions(4)[10]);
    Console.WriteLine(NewPositions(5)[10]);
    Console.WriteLine(NewPositions(100)[10]);
    
   ;
   var newPositions = NewPositions();
   for (int i = 0; i < maxY; i++)
   {
       for (int j = 0; j < maxX; j++)
       {
           if( newPositions.Contains((j,i)))
           {
               Console.Write("#");
           }
           else
           {
               Console.Write(".");
           }
       }
       Console.WriteLine();
   }

    var middleX = maxX / 2 ;
    var middleY = maxY / 2 ;
    var quadrant1 = newPositions.Count(p => p.Item1 < middleX && p.Item2 < middleY);
    var quadrant2 = newPositions.Count(p => p.Item1 > middleX && p.Item2 < middleY);
    var quadrant3 = newPositions.Count(p => p.Item1 < middleX && p.Item2 > middleY);
    var quadrant4 = newPositions.Count(p => p.Item1 > middleX && p.Item2 > middleY);
    Console.WriteLine(quadrant1);
    Console.WriteLine(quadrant2);
    Console.WriteLine(quadrant3);
    Console.WriteLine(quadrant4);
    Console.WriteLine(quadrant1 * quadrant2 * quadrant3 * quadrant4);
}

int mod( int a, int b) {
    return (a % b + b) % b;
}

static bool PositionHasTree(HashSet<(int x, int y)> positions, (int x, int y) position) {
    // 9 in a row
    for( int i = 0; i < 9; i++) {
        if (!positions.Contains((position.x + i, position.y))) {
            return false;
        }
    }
    // 7 in a row above
    for (int i = 1; i < 8; i++) {
        if (!positions.Contains((position.x + i, position.y - 1))) {
            return false;
        }
    }
    // 5 in a row above
    for (int i = 2; i < 7; i++) {
        if (!positions.Contains((position.x + i, position.y - 2))) {
            return false;
        }
    }
    // 3 in a row above
    for (int i = 3; i < 6; i++) {
        if (!positions.Contains((position.x + i, position.y - 3))) {
            return false;
        }
    }
    // 1 above
    if (!positions.Contains((position.x + 4, position.y - 4))) {
        return false;
    }

    return true;
}

static bool MayHaveTree(HashSet<( int x, int y)> positions) {
    foreach (var position in positions) {
        if (PositionHasTree(positions, position)) return true;
    }
    return false;
}

void Part2(string input, int maxX, int maxY) {
    var lines = input.Split(Environment.NewLine);
    var positions = new List<(int x, int y)>();
    var velocities = new List<(int x, int y)>();
    foreach (var line in lines) {
        var match = regex.Match(line);
        positions.Add((int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value)));
        velocities.Add((int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value)));
    }

    HashSet<( int x, int y)> NewPositions(int nbSeconds = 100) {
        return positions
            .Select((p, i) => (mod(p.x + velocities[i].x * nbSeconds, maxX), mod(p.y + velocities[i].y * nbSeconds, maxY)))
            .ToHashSet();
    }


    for (int secs = 1; secs < 200000; secs++)
    {
        var newPositions = NewPositions(secs);
        if (MayHaveTree(newPositions))
        {
            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    if (newPositions.Contains((j, i)))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"--------- {secs} seconds ------");
            break;
        }
    }
}

//Part1(inputReal,101,103);

// 3600 too low, 200 000 too high
Part2(inputReal,101,103);