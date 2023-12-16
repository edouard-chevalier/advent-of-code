namespace Template;

/// <summary>
/// Helper for grids
/// </summary>
public static class Grid
{
    public static bool HasCell(this char[][] grid, int i, int j) {
        return i>=0 && i<grid.Length && j>=0 && j<grid[0].Length;
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
    public static int CountCell(this char[][] grid, Predicate<char> predicate){
        int count = 0;
        foreach(var row in grid) {
            foreach(var cell in row) {
                if( predicate(cell)) {
                    count++;
                }
            }
        }
        return count;
    }
    
    public static bool GoRight(this char[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j + 1)) {
            j++;
            return true;
        }

        return false;
    }
    public static bool GoLeft(this char[][] grid, int i, ref int j) {
        if( grid.HasCell(i, j - 1)) {
            j--;
            return true;
        }

        return false;
    }
    public static bool GoUp(this char[][] grid, ref int i, int j) {
        if( grid.HasCell(i - 1, j)) {
            i--;
            return true;
        }

        return false;
    }
    public static bool GoDown(this char[][] grid, ref int i, int j) {
        if( grid.HasCell(i + 1, j)) {
            i++;
            return true;
        }

        return false;
    }
}