namespace PracticePrgs;

public class EightQueen
{
    //array to every row
    //init chess board
    //check if any coin to right / left
    //check no coin in diagonal

    //if constrainsts dont meet move the coin col++
    public bool[,] board =
    {
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false}
    };
    
    public void PrintBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write((board[i,j])?"  x  " : "  _  ");
            }
            Console.WriteLine("");
        }
    }

    public bool PlaceQueens(int row, int col)
    {
        if (row < 0 || row > 7 || col < 0 || col > 7)
        {
            return false;
        }
        Console.WriteLine($"checking for cell row {row} col {col}");
        if (CheckNEWS(row, col) && CheckDiagonal(row, col))
        {
            Console.WriteLine($"setting cell row {row} col {col}");
            board[row, col] = true;
            //inc row
            return PlaceQueens(row+1, 0);
        } else {
            //inc col
            if (col < 7) {
                return PlaceQueens(row, col+1);
            } else
            {
                if (row-1 >= 0)
                {
                    col = ClearQueenFromRowAndReturnItsPosition(row-1);
                    if (col < 7)
                    {
                        row = row-1;
                        col = col+1;
                    } else
                    {
                        col = ClearQueenFromRowAndReturnItsPosition(row-2);
                        row = row-2;
                        col = col+1;
                    }
                    return PlaceQueens(row, col);
                } else
                {
                    return PlaceQueens(row, col+1);
                }
            }
        }
    }

    public int ClearQueenFromRowAndReturnItsPosition(int row)
    {
        for (int i = 0; i < 7; i++)
        {
            if (board[row, i] == true)
            {
                Console.WriteLine($"revert cell row {row} col {i}");
                board[row, i] = false;
                return i;
            }
        }
        return -1;
    }

    public bool CheckDiagonal(int row, int col)
    {
        if (CheckDiagonalTopLeft(row, col) && 
            CheckDiagonalTopRight(row, col) && 
            CheckDiagonalBottomLeft(row, col) && 
            CheckDiagonalBottomRight(row, col))
        {
            return true;
        }

        return false;
    }

    public bool CheckNEWS(int row, int col)
    {
        //north and south (col constant)
        for (int i = 0; i < 8; i++)
        {
            if (board[i, col] && i != row)
            {
                return false;
            }
        }
        //east and west (row const)
        for (int i = 0; i < 8; i++)
        {
            if (board[row, i] && i != col)
            {
                return false;
            }
        }

        return true;
        
    }

    public bool CheckDiagonalTopLeft(int row, int col)
    {
        //top left 
        while (row >= 0 && col >= 0)
        {
            if (board[row, col])
            {
                return false;    
            }
            row--;
            col--;
        }

        return true;
    }

    public bool CheckDiagonalTopRight(int row, int col)
    {
        //top left 
        while (row >= 0 && col < 8)
        {
            if (board[row, col])
            {
                return false;    
            }
            row--;
            col++;
        }

        return true;
    }

    public bool CheckDiagonalBottomLeft(int row, int col)
    {
        //top left 
        while (row < 8 && col >= 0)
        {
            if (board[row, col])
            {
                return false;    
            }
            row++;
            col--;
        }

        return true;
    }

    public bool CheckDiagonalBottomRight(int row, int col)
    {
        //top left 
        while (row < 8 && col < 8)
        {
            if (board[row, col])
            {
                return false;    
            }
            row++;
            col++;
        }

        return true;
    }
}