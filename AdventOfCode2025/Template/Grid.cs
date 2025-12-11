using System.Text;

namespace Template;

/// <summary>
/// Helper for grids
/// </summary>
public static class Grid
{
    public enum Direction {
        Up,
        Down,
        Left,
        Right
    }
    
    public static Direction Turn90ClockWise( this Direction direction) {
        return direction switch {
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            _ => throw new ArgumentOutOfRangeException() 
        };
    }
    public static Direction Turn90CounterClockWise( this Direction direction) {
        return direction switch {
            Direction.Up => Direction.Left,
            Direction.Left => Direction.Down,
            Direction.Down => Direction.Right,
            Direction.Right => Direction.Up,
            _ => throw new ArgumentOutOfRangeException() 
        };
    }
    
    public static Direction Turn180( this Direction direction) {
        return direction switch {
            Direction.Up => Direction.Down,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            Direction.Right => Direction.Left,
            _ => throw new ArgumentOutOfRangeException() 
        };
    }
    
    public record struct Position {
        public int I;
        public int J;
        public Position(int i, int j) {
            I = i;
            J = j;
        }
    }


    public class Pointer {
        public char[][] Grid { get; private set; }
        public int I ;
        public int J ;
        public Direction Direction { get; private set; }
        public Pointer(char[][] grid, int i, int j,  Direction direction = Direction.Up)
        {
            Grid = grid;
            I = i;
            J = j;
        }
        public void TurnRight() {
            Direction = Direction switch {
                Direction.Up => Direction.Right,
                Direction.Right => Direction.Down,
                Direction.Down => Direction.Left,
                Direction.Left => Direction.Up,
                _ => throw new ArgumentOutOfRangeException() 
            };
        }
        
        public bool CanMove() {
            switch (Direction) {
                case Direction.Up:
                    return Grid.HasCell(I - 1, J);
                case Direction.Down:
                    return Grid.HasCell(I + 1, J);
                case Direction.Left:
                    return Grid.HasCell(I, J - 1);
                case Direction.Right:
                    return Grid.HasCell(I, J + 1);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public char NextCell() {
            switch (Direction) {
                case Direction.Up:
                    return Grid[I - 1][J];
                case Direction.Down:
                    return Grid[I + 1][J];
                case Direction.Left:
                    return Grid[I][J - 1];
                case Direction.Right:
                    return Grid[I][J + 1];
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public bool Move() {
            switch (Direction) {
                case Direction.Up:
                    return Grid.GoUp(ref I, J);
                case Direction.Down:
                    return Grid.GoDown(ref I, J);
                case Direction.Left:
                    return Grid.GoLeft(I, ref J);
                case Direction.Right:
                    return Grid.GoRight(I, ref J);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
    }
    public static bool HasCell<T>(this T[][] grid, int i, int j) {
        return i>=0 && i<grid.Length && j>=0 && j<grid[0].Length;
    }

    public static bool TrySetCell<T>(this T[][] grid, int i, int j, T newVal ) {
        if (HasCell(grid, i, j)) {
            grid[i][j] = newVal;
            return true;
        }

        return false;
    }
    
    public static T GetCell<T>(this T[][] grid, Position pos) {
        return grid[pos.I][pos.J];
    }
    
    public static (int i, int j) FindCell<T>(this T[][] grid, T c) where T : IEquatable<T>{
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if( grid[i][j].Equals(c)) {
                    return (i, j);
                }
            }
        }
        return (-1, -1);
    }
    public static bool TryFindCell<T>(this T[][] grid, T c, out Position pos) where T : IEquatable<T>{
        var result = FindCell(grid, c);
        if( result == (-1, -1)) {
            pos = default;
            return false;
        }
        pos = new Position(result.i, result.j);
        return true;
    }
    
    public static int CountCell(this char[][] grid, char c) {
        int count = 0;
        foreach(var row in grid) {
            foreach(var cell in row) {
                if( cell == c) {
                    count++;
                }
            }
        }
        return count;
    }
    public static void PrintConsole(this char[][] grid){
        Console.WriteLine(grid.Print());
    }
    public static string Print(this char[][] grid) {
        var b = new StringBuilder();
        foreach (var row in grid) {
            b.Append(row);
            b.AppendLine();
        }

        return b.ToString();
    }
    
    public static string Print(this char[][] grid, int line){
           return new string(grid[line]);
    }
    
    public static bool GoRight<T>(this T[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j + 1)) {
            j++;
            return true;
        }

        return false;
    }
    public static bool TryGoRight<T>(this T[][] grid, Position pos, out Position newPosition ) {
        newPosition = pos;
        if (!grid.HasCell(pos.I, pos.J + 1)) return false;
        newPosition = new Position(pos.I, pos.J + 1);
        return true;
    }
    
    public static bool GoLeft<T>(this T[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j - 1)) {
            j--;
            return true;
        }

        return false;
    }
    
    public static bool TryGoLeft<T>(this T[][] grid, Position pos, out Position newPosition ) {
        newPosition = pos;
        if (!grid.HasCell(pos.I, pos.J - 1)) return false;
        newPosition = new Position(pos.I, pos.J - 1);
        return true;
    }
    
    public static bool GoUp<T>(this T[][] grid, ref int i, int j) {
        if( grid.HasCell(i - 1, j)) {
            i--;
            return true;
        }

        return false;
    }
    
    public static bool TryGoUp<T>(this T[][] grid, Position pos, out Position newPosition ) {
        newPosition = pos;
        if (!grid.HasCell(pos.I - 1, pos.J)) return false;
        newPosition = new Position(pos.I - 1, pos.J);
        return true;
    }
    
    public static bool GoDown<T>(this T[][] grid, ref int i, int j) {
        if( grid.HasCell(i + 1, j)) {
            i++;
            return true;
        }

        return false;
    }
    
    public static bool TryGoDown<T>(this T[][] grid, Position pos, out Position newPosition ) {
        newPosition = pos;
        if (!grid.HasCell(pos.I + 1, pos.J)) return false;
        newPosition = new Position(pos.I + 1, pos.J);
        return true;
    }
    public static IEnumerable<Position> Neighbors<T>(this T[][] grid, Position pos) {
        if( grid.TryGoRight(pos, out var right) ) {
            yield return right;
        }
        if( grid.TryGoDown(pos, out var down) ) {
            yield return down;
        }
        if( grid.TryGoLeft(pos, out var left) ) {
            yield return left;
        }
        if( grid.TryGoUp(pos, out var up) ) {
            yield return up;
        }
    }
}