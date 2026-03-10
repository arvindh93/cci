using System.Reflection.Metadata;

namespace PracticePrgs;

public class NumIsland
{
    public void TraverseIsland(char[][] grid, int row, int column, bool[,] visited)
    {
        if (row < 0 || row >= grid.Length || column >= grid[0].Length || column < 0)
        {
            return;
        }
        if (visited[row, column])
        {
            return;
        }
        visited[row, column] = true;
        if (grid[row][column] == '0')
        {
            return;
        }
        TraverseIsland(grid, row+1, column, visited);
        TraverseIsland(grid, row, column+1, visited);
        TraverseIsland(grid, row-1, column, visited);
        TraverseIsland(grid, row, column-1, visited);
        return;
    }
    public int NumIslands(char[][] grid) {
        //check if all zeros, then return 0
        //traverse till you find land
        //pass to travers all land connected to it (count)
        //continue traverse to find more land
        //return count once completed with traversal
        int rowLength = grid.Length;
        int columnLength = grid[0].Length;
        int islandCounter = 0;
        bool[,] visited = new bool[rowLength,columnLength]; //default false

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j <  columnLength; j++)
            {
                //for each point if its island traverse iland and increment counter
                if (!visited[i,j] && grid[i][j] == '1')
                {
                    TraverseIsland(grid, i, j, visited);
                    //increment counter once done traversal
                    islandCounter++;
                }
                visited[i,j] = true;
            }
        }
        
        return islandCounter;
    } 
}