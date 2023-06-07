public class Solution {
    public int StrStr(string haystack, string needle) {
        int haystackIndex = 0;
        int needleIndex = 0;
        while(haystackIndex < haystack.Length)
        {
            if(haystack[haystackIndex] == needle[needleIndex])
            {
                haystackIndex++;
                needleIndex++;
                if(needleIndex == needle.Length)
                {
                    return haystackIndex - needleIndex;
                }
            }
            else
            {
                haystackIndex = haystackIndex - needleIndex + 1;
                needleIndex = 0;
            }
        }
        return -1;
    }
}