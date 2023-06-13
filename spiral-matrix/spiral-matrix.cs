public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> res = new();
        int m = matrix.Length; // row
        int n = matrix[0].Length; // col
        int r = n -1, l = 0;
        int t = 0, b = m - 1;

        while(true)
        {
            // to right
            for(int i = l; i <= r; i++)
            {
                res.Add(matrix[t][i]);
            }
            t++;
            if(t > b)
            {
                break;
            }
            // to bottom
            for(int i = t; i <= b; i++)
            {
                res.Add(matrix[i][r]);
            }
            r--;
            if(l > r)
            {
                break;
            }
            // to left
            for(int i = r; i >= l; i--)
            {
                res.Add(matrix[b][i]);
            }
            b--;
            if(b < t)
            {
                break;
            }
            // to top
            for(int i = b; i >= t; i--)
            {
                res.Add(matrix[i][l]);
            }
            l++;
            if(l > r)
            {
                break;
            }
        }
        return res;
    }
}