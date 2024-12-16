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
    public static void Print(this char[][] grid){
        int count = 0;
        foreach(var row in grid) {
            Console.WriteLine(new string(row));
        }
    }
    
    public static bool GoRight<T>(this T[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j + 1)) {
            j++;
            return true;
        }

        return false;
    }
    
    public static bool GoLeft<T>(this T[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j - 1)) {
            j--;
            return true;
        }

        return false;
    }
    public static bool GoUp<T>(this T[][] grid, ref int i, int j) {
        if( grid.HasCell(i - 1, j)) {
            i--;
            return true;
        }

        return false;
    }
    public static bool GoDown<T>(this T[][] grid, ref int i, int j) {
        if( grid.HasCell(i + 1, j)) {
            i++;
            return true;
        }

        return false;
    }
}