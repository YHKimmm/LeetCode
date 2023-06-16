public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<List<int>> res = new();
        for(int i = 0; i < intervals.Length; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];
            while(i < intervals.Length - 1 && end >= intervals[i+1][0])
            {
                end = Math.Max(end, intervals[i+1][1]);
                i++;
            }
            res.Add(new List<int> {start, end});
        }
        return res.Select(x => x.ToArray()).ToArray();
    }
}