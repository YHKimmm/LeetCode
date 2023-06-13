public class Solution {
    public void Rotate(int[][] matrix) {
        List<int> res = new();
        int n = matrix.Length; //3
        for (int i = 0; i < n; i++)
        {
            int c = n - 1;
            for (int j = 0; j < n; j++)
            {
                res.Add(matrix[c][i]);
                c--;
            }
        }
        int idx = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = res[idx];
                idx++;
            }
        }
    }
}