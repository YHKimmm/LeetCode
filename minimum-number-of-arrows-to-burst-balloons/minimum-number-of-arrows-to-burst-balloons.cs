public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a,b) => a[1].CompareTo(b[1]));
        int res = 1;
        int preArrow = points[0][1];
        for(int i = 1; i < points.Length; i++)
        {
            int start = points[i][0];
            int end = points[i][1];
            if(start <= preArrow && preArrow <= end)
            {
                continue;
            }
            else
            {
                res++;
                preArrow = points[i][1];
            }
        }        
        return res;
    }
}