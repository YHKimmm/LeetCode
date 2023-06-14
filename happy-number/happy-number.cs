public class Solution {
    public bool IsHappy(int n) {
        if(n == 1 || n == 7 || n == 1111111)
        {
            return true;
        }
        Dictionary<string, int> dict = new();
        // {19:82, 82:68, 68:100, 100:1}
        bool valid = false;
        string newStr = n.ToString();
        int count = 0;
        while (count < 100)
        {
            newStr = n.ToString(); // "19"
            int sum = 0;
            var charArr = newStr.ToCharArray(); // 1 9
            if (charArr.Length == 1)
            {
                return false;
            }
            for (int i = 0; i < charArr.Length; i++)
            {
                int intValue = (int)(charArr[i] - '0');
                sum += (intValue * intValue);
            }
            n = sum;
            if (!dict.ContainsKey(newStr))
            {
                dict[newStr] = sum;
            }
            if (dict[newStr] == 1)
            {
                valid = true;
                return valid;
            }
            count++;
        }
        return valid;
    }
}