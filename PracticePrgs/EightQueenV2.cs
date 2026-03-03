namespace PracticePrgs;

public class EightQueenV2
{
    public const int GRID_SIZE = 8;

    public void Main()
    {
        int[] board = new int[GRID_SIZE];
        Solve(board, 0);
    }

    public void Printboard(int[] board)
    {
        for (int i = 0; i < GRID_SIZE; i++)
        {
            for (int j = 0; j < GRID_SIZE; j++)
            {
                if (board[i] == j)
                {
                    Console.Write("X ");
                } else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine("");
        }
    }

    public bool Solve(int[] board, int row)
    {             
        if (row == GRID_SIZE)
        {
            Printboard(board);
            return true;
        }

        for (int i = 0; i < GRID_SIZE; i++)
        {
            if (IsSafe (board, row, i))
            {
                board[row] = i;
                Solve(board, row + 1);
            }
        }

        return false;
    }

    public bool IsSafe(int[] board, int row, int col)
    {
        for (int rowi = 0; rowi < row; rowi++)
        {
            //check straight cells
            if (board[rowi] == col)
            {
                return false;
            }

            //check diagonal
            if (Math.Abs(board[rowi] - col) == Math.Abs(row - rowi))
            {
                return false;
            }
        }
        return true;
    }
}