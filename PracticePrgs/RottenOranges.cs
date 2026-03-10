using System.ComponentModel.DataAnnotations.Schema;

namespace PracticePrgs;

public class RottenOranges
{
    private int maxMinute = -1;
    public void RotOranges(int[][] grid, int row, int column,int min, bool[,] visited, int[,] minute)
    {
        if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length)
        {
            return;
        }
        if (!visited[row, column])
        {
            visited[row, column] = true;
        }
        if (grid[row][column] == 0)
        {
            return;
        }
        if (grid[row][column] == 2)
        {
            //if already rotten, then change min to zero
            min = 0;
        }
        if (minute[row, column] > min)
        {
            minute[row, column] = min;
            RotOranges(grid, row+1, column, min + 1, visited, minute);
            RotOranges(grid, row, column + 1, min + 1, visited, minute);
            RotOranges(grid, row - 1, column, min + 1, visited, minute);
            RotOranges(grid, row, column - 1, min + 1, visited, minute);   
        }
    }
    public int OrangesRotting(int[][] grid) {
        //check if there is rotten orange
        //maintain visited grid
        //minute counter
        //max minute 
        int rowLength = grid.Length;
        int columnLength = grid[0].Length;
        bool[,] visited = new bool[rowLength, columnLength];
        int [,] minute = new int[rowLength, columnLength];
        for (int i = 0; i < rowLength; i++)
        {
            for(int j = 0; j < columnLength; j++)
            {
                minute[i,j] = int.MaxValue;
            }
        }

        for (int i = 0; i < rowLength; i++)
        {
            for(int j = 0; j < columnLength; j++)
            {
                //check if its rotten orange
                if (!visited[i,j] && grid[i][j] == 2)
                {
                    RotOranges(grid, i, j, 0, visited, minute);
                }
                visited[i,j] = true;
            }
        }

        bool hasNoOrange = true;
        for (int i = 0; i < rowLength; i++)
        {
            for(int j = 0; j < columnLength; j++)
            {
                if (grid[i][j] == 1 && minute[i,j] == int.MaxValue)
                {
                    //there is fresh fruit in basket
                    return -1;
                } else if (grid[i][j] != 0)
                {
                    hasNoOrange = false;
                    maxMinute = Math.Max(maxMinute, minute[i,j]);
                }
            }
        }

        if (hasNoOrange)
        {
            return 0;
        }

        return maxMinute;
    }
}