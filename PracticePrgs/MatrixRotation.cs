using System.Reflection.Metadata.Ecma335;

namespace PracticePrgs {
    public class MatrixRotation {
        public void RotateNxN90(ref int[,] matrix)
        {
            //get N from first row
            int matDim = matrix.GetLength(0);
            int temp;

            if (matDim == 1)
            {
                return;
            }
            for (int layer = 0; layer < matDim / 2; layer++)
            {
                int first = layer;   
                int last = matDim - layer - 1;
                for (int j = first; j < last; j++)
                {
                    int offset = j - first;

                    //top
                    temp = matrix[first,j];

                    //left -> top
                    matrix[first,j] = matrix[last-offset,first];

                    //bottom -> left
                    matrix[last-offset,first] = matrix[last,last-offset];

                    //right -> bottom
                    matrix[last,last-offset] = matrix[j, last];

                    //top -> right
                    matrix[j, last] = temp;
                }
            }
        }
    }
}