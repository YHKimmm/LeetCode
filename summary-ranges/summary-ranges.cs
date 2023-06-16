public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        HashSet<int> seen = new();
        List<string> res = new();
        foreach (int num in nums)
        {
            int nextVal = num + 1;
            if (!set.Contains(nextVal) && !seen.Contains(num))
            {
                string str = num.ToString();
                res.Add(str);
            }
            else
            {
                while (set.Contains(nextVal) && !seen.Contains(num))
                {
                    seen.Add(nextVal);
                    nextVal++;
                }
                if (!set.Contains(nextVal) && !seen.Contains(num))
                {
                    if(num == int.MaxValue)
                    {
                        res.Add($"{num}");
                    }
                    else
                    {
                        res.Add($"{num}->{nextVal - 1}");
                    }
                }
            }
        }
        return res;
    }
}