public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<List<int>> res = new();
        List<List<int>> mergeIntervals = new();
        foreach (var interval in intervals)
        {
            mergeIntervals.Add(interval.ToList());
        }
        mergeIntervals.Add(newInterval.ToList());
        var merge = mergeIntervals.Select(x => x.ToArray()).ToArray();
        Array.Sort(merge, (a, b) => a[0].CompareTo(b[0]));
        //[[1,3], [2,5], [6,9]]
        for (int i = 0; i < merge.Length; i++)
        {
            int start = merge[i][0];
            int end = merge[i][1];

            while (i < merge.Length - 1 && end >= merge[i + 1][0])
            {
                end = Math.Max(end, merge[i + 1][1]);
                i++;
            }
            res.Add(new List<int> { start, end });
        }
        return res.Select(x => x.ToArray()).ToArray();
    }
}