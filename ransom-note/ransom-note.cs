public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {

        Dictionary<char, int> ransomDict = new();
        Dictionary<char, int> magazineDict = new();

        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(ransomDict.ContainsKey(ransomNote[i]))
            {
                ransomDict[ransomNote[i]] += 1;
            }
            else
            {
                ransomDict[ransomNote[i]] = 1;
            }
        }

        for(int i = 0; i < magazine.Length; i++)
        {
            if(magazineDict.ContainsKey(magazine[i]))
            {
                magazineDict[magazine[i]] += 1;
            }
            else
            {
                magazineDict[magazine[i]] = 1;
            }
        }
        // {a:2, c:1} {a:2, b:1} -> F
        // {a:2} {a:2, b:1} -> T
        // "aac" "aab"
        bool valid = false;
        foreach (var ele in ransomDict)
        {
            if (magazineDict.ContainsKey(ele.Key) && ele.Value <= magazineDict[ele.Key])
            {
                valid = true;
            }
            else
            {
                return false;
            }
        }
        return valid;
    }
}