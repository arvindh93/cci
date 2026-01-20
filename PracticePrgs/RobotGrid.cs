namespace PracticePrgs;

public class RobotGrid
{
    public bool CanReach(int row, int col, int maxRow, int maxCol, List<(int , int)> offList)
    {
        if (row > maxRow || col > maxCol)
        {
            return false;
        }
        if (offList.Contains((row, col)))
        {
            return false;
        }
        if (row == maxRow - 1 && col == maxRow -1)
        {
            return true;
        }

        return CanReach(row+1, col, maxRow, maxCol, offList) || CanReach(row, col+1, maxRow, maxCol, offList);
    }
}