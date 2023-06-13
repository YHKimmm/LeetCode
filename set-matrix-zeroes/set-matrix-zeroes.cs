public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length; //3
        int n = matrix[0].Length; //4
        HashSet<int> idxSet = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    idxSet.Add(j);
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    j = 0;
                    while (j < n)
                    {
                        matrix[i][j] = 0;
                        j++;
                    }
                }
                if (idxSet.Contains(j))
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}