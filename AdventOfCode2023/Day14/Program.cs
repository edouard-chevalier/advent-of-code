// See https://aka.ms/new-console-template for more information


using System.Collections;

Console.WriteLine("Hello, World!");

const string inputReal = @"O.O#..O.#...#..O.O#..O#...O..O.#...O#.OO.O...#....#.O.##..####.OOO....OO......##..........#O.#O.O.#.
..O.#..#O...#..#.....O..O..OO..#.O..O#..#O#...#......O.O.O......#..OO##...O..#.O.O..#...#O....O.OO..
....O#O#.O#...#..O.O#..#.....O....#.....OOO#OO.#....#...#.O.OOOO..#O.O##....##..O.....##.OOO.#..##..
OO...OO...#..OOO..#....O.#.......##O....#..O.O#..#.O.#..O.#O.#.#..#....#...O.......O#O.....OOO###...
..#...#...O.O....#..O.....#...OO.##O...#O...#.#.O#O.OO.OO.O...#O#...#.#...#.....O..#..O##.##.OO..#.O
..#.#.O.#OO#...#.#O##O.OO..#......#OO....O........#OO#..O.O.....#.....O.O..O.#O#..O......O....O.##.#
.....O..O......O...#.#.#.....#OOO##O.#O...O...O.O..#...#O##.OO......O......OO..O#..##......#OO#..O..
...#...O.#O.......#.O....#..#.....#.O.#.....#..O..#.....O#..O#.O.O......O###O#..O...OO..##........##
.......#O..O..O........#...#....O..#...#.....#.....#.#O.#.O...O#.....OO.O........#O#O.O..#.....O#O..
OOO....OO..#O.O#....O#O....OO...O.O...O..O.#..O#........OO....#...#.....OO..O#....##OO#.O#O........O
#.#......O..O...O###O.OO..##......#........O........O......O..O..O.....O.##.O...O..O..OO.O##O.O..#O.
...O.............#.OO.O#.#.....O.O#..OO#.............O..OO.#.O.#O#.O....#..#........O.#.O.......O#..
.............OO#.....O.O..O..O...O.O..#..#.#..O....OO#..OO..#.O..O#.....#.#....O.O...#.#O....#...O.#
..O..#O.#.#OOO.....#O..OO.##....O..##.O.....O....O..#.#...O.O..O##...O...O..#..O.#O.##.......O...#..
...O#.....O#O...O....OOO...#.#....##O.....OOO.##...OO.........#.#.#..O....#O#.OO.O........O.........
.......#........#....OO........O...OO.##...O.#.....#....O..OO.O.#...OO..O...O..O....O.#....#.......#
..#....#...##O..#....O#..O.O....#....#..###.#.O.....###..OO....#...OO.OOO#O...##...O.#O#...O...O.O..
O#..O#...OO..#.......#....OOO...OO.O...OO...##.O..O##.O......#....#O.O..O#OOO.#.O#O.......OO...OO...
OO.#.#...#..O.#.#.OO..OO.#O.#..O....OOO.#.....O.OO....O.#.#..##.....O.#...O......#OO#..O.O..#.....#.
O.....O..O..........O....O..#..#...........#.#O.......#....O.#..##....#O#...#O.O...O#O..#O#..OO.#.O.
.#.##....O.#...OO##O.#..O..OO........O...O......O#OO..OO.O...#..#.O#O.......O#...O.O#..#OOO.O...OO#.
..O..#OO#O#.O..O..#......#.O..#...O..O..O...##O.O..##.....#O.O.OOO.O..O...O...O..O..O....#......#OO.
...OOOO.#.#.O.OO#......#.#.O..O.#...O..O..#......#....##O.#.O.#O#O....###.#..#.....O#.O........O....
..OO#.........OOO..........O...O..###...##...O........#....O.O#O....#...............#...O..O.O...#..
.O......#O.OO.....O..#........O#OO.....O....O.O#.O.O...O....#..O#O....#.....O...O#O.O..#.OO..##.#.#.
....O.O#..#...O#.O.O.#......OO..O#..#..#..##...O.#..###.O#.O..O#....O.#..O.O#..##O#....#O.OO#.#.....
O##..#.....##...O......#..O....#O..#O...O.........O..OO......#.#OO##...#.....#......O.....O#..O..#..
.##.O#O#O...O..#...........#OO....O.#.O.O.#.#O.#..#...O........O...#...#..OOO..##..O......O##O#.....
...O...O#.....#O..#..#..O.#.##O..........#.O..###.O..O#O....O...O#O....OO.O..#.#.O#O#.....#.#.O.OO#O
...O..#O.#O......O....O...O..O#......OO...#..O.OO.O.#..#..#......OOO..#.....OO....O..#.#O......O....
.....#...##.....O#..O.....#O.#..OO..#.#..##....#.O.#......#.#O.O..O.O.......O......O#.O#O#...OO...#.
......##.O#....O#.....O......#OO#...O....O#....#....O...#..#.#....OO...##OO..#.....##..O..O.O...O..O
OO##..#...OO.......O...#..#..O.....O..OO.OO.#..#.#O.#O..#O.##..............O...O.#O..#..#.O......##.
..O.#.....O#O......O#O#..O.O.....#...OO.#.O.#....#.###....#.#...........O#O.....OO.#..O...#..OO...#O
#..O..O..O#..O...#O.#...###..O..#.O#.#OO.......OO..........O..OOO...#....OO......O..OO#.OO#...O.O.O.
O.O..O..##..O...O.#O#.O.#.O..#O.OO#.OO..O..#...O.........#OO.......O...OO..####O...O..O...#OOO..O.O.
O..#.O.#.OOO...#O.....O#O.#O#.OO...#OO.#.##.........O..O#O#.#.O#...O..O....O..#O...O#O...O..O.O.....
O.O..O...#.O#.#...O..#.O.#.O##.O..#..#...OO#...##.O.#.##.OOO.#.........O.O....#..O.O.....#......OOO.
O..#O.#....OO#..O.##........O...#.#.....OO.....#O...OO........OO.#OO.....#.......O.#..OO#..O.#O#....
.OO..O.#..#...O.O.OOO#.O...O.O..OO.#O#..OO..#.....#.#..O....O.#O.##...O..O.....#...##...O.O#O...O..O
#....O.#......OO....#..O#.OOO..O.#...O.........###O.....##..O..O.O.O.O....##.....O...O.O..O.O.....O.
#...OO...O....##O........O.O..OO..#.....#.....OO...O...O.....#..O...#.....#.#...#...................
...O....O..OO.OO.......##...#OOO.....O..OO.O#.#........O..O.O....O.#.O#...#.#.........#......O....#.
O.........#..#..##..OO#....#..OO#O....O.O...O...................O.....O..OO.O.O.O..O.#...#...O.#.#O.
....#.O#.O..#..#..#...#OO.#.......O.#....O...O...#.##...O...O....O#.O.....O#....#.#......#.#..O.O.O.
#O##.#.....#.##O..#...O...###.OO......#......#O....#..#..O........#.O..O.....O#..O...OO#..OO.#.OO.OO
.O#.###O.O.#...####O....#.##O.O##.#..#.#..O........###.#....##O....O.O....OO.O...O.#O...OOO##...#.O.
....O..O....O............O.O......OO.##..#OO..#O...#.O.O..#..#O.O.........##.#..#..OO.....O.......#.
O....##.#O...O.OO..O#..O...#...O.OO.#..O.#......#.O..#.#..........O###...OOO.O..#.......O.O.O......O
.#......##...O.....#.O.....O.#.......O#O...O#.O.......O..#O..O#...O..O..OO#..#.O#...O.#.#.O...#.#.OO
...O.#.O.#......##..O..........OOO.....O.O......O.....O..#.O..#...#.OOO...O..#..#...#......O...#...O
..O..OO...#..#O....OO...#O...O#..O##....O#....#..#.#...#...........###...........#...OO...OO........
OO....O...#OO..O..O.O.O..#.O.....O.#...O........OO...#......O.#....O..O.#.##.........OO.O#...O.OO...
.#.....O.O#O..O.....#.#...O.O##O.......#..O#.#.#.OO#.O.O.#O#..OO..O.#O..O.OOOO......O....O...#..#...
#......O..#...O..#.O....#..OO...#.........O.O...#..O......O.O.O.#.O.......O..##..O#.#..O..#....OO.#.
.O..##O#O.O.O....#...#..O#.#.#.......O........#..#OO.OO..O..O.#...O..OOOO.....O#....O####.......#...
.#OO#.O.#..........OO..O.......O#....#.OO#...##......####...O...OOO...#....O.#..O.......#..O.O......
....O..#........#OO.......O.#..O...O..O..#.O....#.O.O.O..OO.O#O.O..O.###..O.#.#.......#.#...O#...O..
OO....O#O.O.#.#.##O#.#O#....#....O.O.......O.O.OO....O#.....O.O.OO#.##.O.#..##O..O..O#O......O...O#O
.#...#O..##.##.OO....##.....#O...#.O.O..#.....##......OO#OO.#...O...#..O....O#.#.O..O.#.......O.#.#O
O.#OO#OOO..O.#..OO..O......#O...O....##..#..#O...OO#.#.OO........O.#...O..O#OOO.O....##.O.O........#
.###..O.O...O#O..OO.O....#...OO.OO.O..OO..O.O.O.........#.O#...#...#..O..#..O..OO..#.O.....OO#......
.O#...O#..#.....O......O##..O.O.O..#..#.#.....#...#....#..#...O.O#..O...O..#...O......#.#...O.....O.
.O#..OO#.O.O...#O...O.....#....##..####.....O..O.....O...#O..#.......#OOO#.#....O.......O.#O.#..O#..
......O.O#....O.......O.O...O..O#..O...#....#O..##OO.#O......OOO.....#.#O.O#.O#.O....O#O#O..###.#...
#.O....#O......OOO......##.O.OO....#O...#OO...OO.##...O.O..#OO..OOO#..#.O.........O#...O........#...
.O....#.......O#.O..##...O##OO......#..O.O#O.O.#...........#OO........O...O....#.............#.#..O.
....#O.#..#.#..........OO...O..........O....O#...#OO.......O...O.#OO..OOO....O.O#..O.O.###..O.O#...O
O...#..OO....O.......#.OO...O........O.OO..#..#..#.#.O..O.#....O.O......OO..OO.O..#..OOO#..OOO......
.OO#.O.....O..#...O.....O....O#........#....#.....O..#..###...#.O.......OO......O..O.OO..O..#.O#O#..
O....O...##.#....#O..O.#......................O..O#OOO..##....#.#..O.O.....O#..O.O.O...#.#.OOO...O..
.......O..OO.O..O#.OO.#.O..#O....#.OOO.........##......#.O#.O..O....O....O.....#O.O...O.#.......O.#O
....O##.#...O.##...O#...OOOO...OO...#.O.#...O.#O.......#.O.....##....O.#O....#......##.O....O.OO#..O
OO...O#O#O#.#OO.#O.O..#.#.#.#.............#.O........#...O..O......O#.#OO.O...#.O..O...O#.O....O#..O
.#..O..#.OO.#O...O#.O.#.#..#.......#.......#O...#..#O#....O...#....OO.....O......O..#.....O..O..#.O#
...OO....O.#....#.O.#..#.#O.#.#O.....O..O##.......O..#O.#.O...OOO#O.#......O....#......#......O##...
...##.O.O.....##....O.....#O..O........#.#.O#O....O#..O...O#OO...O....O..O.O.#.#..#OO...O..#....OO..
O...#OO.O.OO#..O....##O...#....#...#.O.O..O.........#..##.#O.#.OO..OO...#...O.O#.OO..#.O.OO#.#..##OO
..O.O#..O..#O...O.#.O.#....#....#.#O...O..O#O....#...#..#..##......#.O..........OOO........O.#......
.....#....#....OO....#....O.#O..O...O#O..#...###....O.....O........##.#.#..#.O.OO.#O.O.O..#...O#O..O
.OO.....O.O.....#....O.O....O......O#O....O#.#..O....O.#............#..O.#.....OO....O...O....O.#.O.
.........O#OO.#O.....O......O...#..#O..O.#...O.O..OO.........#.O#OO.#.OO.........#.OO..O.O#O..O.O#..
#...O...O....#O.###.....O.OO..O..OO.O#O....#O..#O..OO..O..#........O...#.....#..#...OO..O....#.....O
......O.O.OO#.O.......O#O.OO.#..O....O...#.O#..#....O.#....#..#O...#.OO.O#........#......O....O.O...
..#...##...#.O.O..#...O#.....##.......OO..O.#....O.O#O#..O...O#..OO...##O...O..O.....#.#...O.O......
OOO.O.O#O......#..OO.O...OO...O............O..O#..##O...###.#......O#..#.O..O.OOO...#..O#......#OO.#
O###.......#.O.O.#.....#.OO..O.O...#..O#O..#O.O.#.O..O.O..O#.#....#..#...O#..###.#..O#.O.........OO.
.......#O#OO#...#.#...#.O...O.....O.O#.....O.O.O##.#...#O.#....OO...O.OO..O....O.O..#..#.....O...#..
.O..###..OO#O.#.#OO.O#...#..O#...O.....O#.O......O...OO..O..O.....O..##.....OO.....O......O........O
..O..#.O.#..OO.O#..O#..O.....OO#O#....OO.OO#O...O...O.O......OO.#O#....O..#O.#.OO##.#....#O#.#......
O.#O.O.O.O...OO.....O.#...##..#....O....O..#..#O#..O#.#.OO.#O..........#...O..##..O.##.O.O...#.#O..#
......O#...O.#..O#.O.........#.#....O.O....O.#..O..O##.#..O....#..#O#.OO.........#.O##O.....OO.OO.O.
#....#.#O.O.O............O.O.#.O..O.........O..O........O......O.....OO.OO..OO.#....OO.OO.#....#..##
.......#...O.O.#.O.....#.O#.#..O..O...O.O.#O..#...##.........O..#.OO..O........#.....#.......OO.....
...#....O...O...#O.OO...#....#..O.#.O.#......##.#.#.OO.O.O...#..#..O........O.##..O...O#O...OO.O....
.......OO...O..O...........O###......#....O.......O..O.....O#...#.O.#.#......O..O.....#.#OO.......O.
.#..#.....#.O..O..O.....##..O.........O#.##O....OO...O...#..O.O.##OO......O.#..O....O..O.#.O.O...O.O
.O....O...O....#.O......#..##O.#..O..O.....O...OO..###....#..#..#..........#.#.#.#.#........O...O.O.
.OOO.#.#O....O.#...OO#.##...#...O.#...OO..###..OO.#.O....O..OO#..O..O....O#.#.O####..O....O..O#O....
.OO.OO#......#....#..##O#O...OO....#....O......OO..OOO.....##.......O#.#.O.#O......O..#.#O..O.O..#..";
const string inputTest = @"O....#....
O.OO#....#
.....##...
OO.#O....O
.O.....O#.
O.#..O.#.#
..O..#O..O
.......O..
#....###..
#OO..#....";

/*
var input = inputReal;
var grid = input.Split(Environment.NewLine).Select(s => s.ToCharArray()).ToArray();
int limitNorth = 0;
int limitSouth = grid.Length - 1;
int limitWest = 0;
int limitEast = grid[0].Length - 1;
var rockPosition = new List<(int i, int j)>();
void MoveNorth(ref int i, ref int j) {
    while (i > limitNorth && grid[i-1][j] == '.') {
        grid[i][j] = '.';
        grid[i - 1][j] = 'O';
        i--;
    }
}
void MoveSouth(ref int i, ref int j) {
    while (i < limitSouth && grid[i+1][j] == '.') {
        grid[i][j] = '.';
        grid[i + 1][j] = 'O';
        i++;
    }
}

void MoveWest(ref int i, ref int j) {
    while (j > limitWest && grid[i][j-1] == '.') {
        grid[i][j] = '.';
        grid[i][j-1] = 'O';
        j--;
    }
}

void MoveEast(ref int i, ref int j) {
    while (j < limitEast && grid[i][j+1] == '.') {
        grid[i][j] = '.';
        grid[i][j+1] = 'O';
        j++;
    }
}
for (int i = 0; i < grid.Length; i++) {
    for (int j = 0; j < grid[i].Length; j++) {
        if( grid[i][j] == 'O') {
            rockPosition.Add((i,j));
        }
    }
}

for (int i = 0; i < rockPosition.Count; i++) {
    var(k,l) = rockPosition[i];
    MoveNorth(ref k, ref l);
    rockPosition[i] = (k, l);
}

long sum = 0;
for (int i = 0; i < grid.Length; i++) {
    for (int j = 0; j < grid[i].Length; j++) {
        if( grid[i][j] == 'O') {
            sum+=grid.Length - i;
        }
    }
}

foreach (var line in grid)
{
    Console.WriteLine(new string(line));
}
Console.WriteLine(sum);
*/

var input = inputReal;
var grid = input.Split(Environment.NewLine).Select(s => s.ToCharArray()).ToArray();
int nbLines = grid.Length;
int nbColumns = grid[0].Length;
int limitNorth = 0;
int limitSouth = grid.Length - 1;
int limitWest = 0;
int limitEast = grid[0].Length - 1;


void MoveNorth(int i, int j) {
    while (i > limitNorth && grid[i-1][j] == '.') {
        grid[i][j] = '.';
        grid[i - 1][j] = 'O';
        i--;
    }
}
void MoveSouth(int i, int j) {
    while (i < limitSouth && grid[i+1][j] == '.') {
        grid[i][j] = '.';
        grid[i + 1][j] = 'O';
        i++;
    }
}

void MoveWest(int i, int j) {
    while (j > limitWest && grid[i][j-1] == '.') {
        grid[i][j] = '.';
        grid[i][j-1] = 'O';
        j--;
    }
}

void MoveEast( int i, int j) {
    while (j < limitEast && grid[i][j+1] == '.') {
        grid[i][j] = '.';
        grid[i][j+1] = 'O';
        j++;
    }
}

void Tilt()
{
    for (int i = 0; i < nbLines; i++) {
        for (int j = 0; j < nbColumns; j++) {
            if( grid[i][j] == 'O') {
                MoveNorth(i, j);
            }
        }
    }
   // PrintGrid();

    for (int j = 0; j < nbColumns; j++) {
        for (int i = 0; i < nbLines; i++) {
            if (grid[i][j] == 'O') {
                MoveWest(i, j);
            }
        }
    }
    
    //PrintGrid();
    for (int i = nbLines -1; i>=0; i--) {
        for (int j = 0; j < nbColumns; j++) {
            if (grid[i][j] == 'O')
            {
                MoveSouth(i, j);
            }
        }
    }
    //PrintGrid();
    for (int j = nbColumns -1; j>=0; j--) {
        for (int i = 0; i < nbLines; i++) {
            if (grid[i][j] == 'O')
            {
                MoveEast(i, j);
            }
        }
    }
   // PrintGrid();

}

string GridString()
{
    return string.Join("\n", grid.Select(s => new string(s)));
}

var dict = new Dictionary<string, int>();
int nbStepLimit = 1000000000;
/*for (int i = 0; i < nbStepLimit; i++)
{
    if (i % 1000000 == 0)
    {
        Console.WriteLine(i);
    }
    Tilt();
}*/
Console.WriteLine(Score());
int nbStep = 0;
do
{
  /*if (nbStep > 0 && nbStep <= 3)
    {
        Console.WriteLine($"at {nbStep}");
        PrintGrid();
    }*/

    Tilt();
    //PrintGrid();
    var gridString = GridString();
    if (dict.ContainsKey(gridString))
    {
        Console.WriteLine("found circle at step " + nbStep + $"that was at {dict[gridString]}");
        break;
    }
    dict.Add(gridString, nbStep);
} while (++nbStep < nbStepLimit);


int nbStepInCircle = nbStep - dict[GridString()];
/*for (int i = 0; i < nbStepInCircle; i++)
{
    Tilt();
    PrintGrid();
}*/
Console.WriteLine(nbStep);

for (;  nbStep<nbStepLimit; nbStep+=nbStepInCircle) { }
Console.WriteLine(nbStep);

nbStep -= nbStepInCircle;
for (;  nbStep<nbStepLimit-1; nbStep++)
{
    //Console.WriteLine(nbStep);

    Tilt();
   // PrintGrid();
}

void PrintGrid()
{
    Console.WriteLine("Score " + Score());
    foreach (var line in grid)
    {
        Console.WriteLine(new string(line));
    }
}

long Score()
{
    long sum = 0;
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] == 'O')
            {
                sum += grid.Length - i;
            }
        }
    }

    return sum;
}

Console.WriteLine(Score());

public class Eq : IEqualityComparer<IReadOnlyList<(int i, int j)>>
{
    public bool Equals(IReadOnlyList<(int i, int j)>? x, IReadOnlyList<(int i, int j)>? y)
    {
        for (int i = 0; i < x.Count; i++)
        {
            if (x[i] != y[i])
            {
                return false;
            }
        }

        return true;
    }
    public int GetHashCode(IReadOnlyList<(int i, int j)> obj)
    {
        int value=0;
        for (var i = 0;i< obj.Count; i++) {
            value=HashCode.Combine(obj[i],value);
        }

        return value;
    }
}
