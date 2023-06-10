public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> set = new();
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                char n = board[i][j];
                if(n == '.')
                {
                    continue;
                }
                string rowKey = $"Row:{j}, Number:{n}";
                string colKey = $"Column:{i}, Number:{n}";
                string gridKey = $"Block:{i/3}-{j/3}, Number:{n}";
                if(set.Contains(rowKey) || set.Contains(colKey) || set.Contains(gridKey))
                {
                    return false;
                }
                set.Add(rowKey);
                set.Add(colKey);
                set.Add(gridKey);
            }
        }
        return true;
    }
}