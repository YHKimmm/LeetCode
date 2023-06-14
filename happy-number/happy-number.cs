public class Solution {
    public bool IsHappy(int n) {
        // n = 2 -> 4 16 37 58 89 145 42 20 4
        HashSet<int> set = new();
        while(n != 1)
        {
            int sum = 0;
            string newStr = n.ToString();
            foreach(char c in newStr)
            {
                int newInt = (int)c - '0';
                sum += (newInt * newInt);
            }
            if(set.Contains(sum))
            {
                return false;
            }
            set.Add(sum);
            n = sum;
        } 
        return true;
    }
}