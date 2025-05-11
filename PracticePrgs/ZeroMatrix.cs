namespace PracticePrgs{
    public class ZeroMatrix {
        public void CheckAndAddZeroes(ref int [,] mat)
        {
            int rowLength = mat.GetLength(0);
            int colLength = mat.GetLength(1);
            List<int> rowIndex = new List<int>();
            List<int> colIndex = new List<int>();
            for (int i = 0; i < rowLength ; i++) {
                for (int j = 0; j < colLength; j++) {
                    if (mat[i,j] == 0)
                    {
                        rowIndex.Add(i);
                        colIndex.Add(j);
                    }
                }
            }
            for (int i = 0; i < rowLength ; i++) {
                for (int j = 0; j < colLength; j++) {
                    if (rowIndex.Contains(i)) {
                        mat[i,j] = 0;
                    }
                    if (colIndex.Contains(j)) {
                        mat[i,j] = 0;
                    }
                }
            }
        }
    }
}