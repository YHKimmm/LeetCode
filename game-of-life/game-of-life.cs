public class Solution {
    public void GameOfLife(int[][] board) {
        // original | new
        //      0       0       0
        //      1       0       -1 ->Math.Abs(1)
        //      0       1       2
        //      1       1       1
        int[][] directions = new int[][]
        {
            new int[] {-1,-1},
            new int[] {-1,0},
            new int[] {-1,1},
            new int[] {0,1},
            new int[] {0,-1},
            new int[] {1,-1},
            new int[] {1, 0},
            new int[] {1,1}
        };
        int m = board.Length;
        int n = board[0].Length;

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int liveCount = 0;
                foreach(var dir in directions)
                {
                    int x = dir[0] + i;
                    int y = dir[1] + j;
                    if(x >= 0 && x < m && y >= 0 && y < n && Math.Abs(board[x][y]) == 1)
                    {
                        liveCount++;
                    }
                }
                if(board[i][j] == 1)
                {
                    if(liveCount < 2 || liveCount > 3)
                    {
                        board[i][j] = -1;
                    }
                }
                else if(board[i][j] == 0)
                {
                    if(liveCount == 3)
                    {
                        board[i][j] = 2;
                    }
                }
            }
        }

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(board[i][j] == -1)
                {
                    board[i][j] = 0;
                }
                else if(board[i][j] == 2)
                {
                    board[i][j] = 1;
                }
            }
        }
        
    }
}