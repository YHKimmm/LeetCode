public class Solution {
    public void GameOfLife(int[][] board) {
        int[][] directions = new int[][] {
        new int[] {-1, 0},
        new int[] {-1, 1},
        new int[] {0, 1},
        new int[] {1, 1},
        new int[] {1, 0},
        new int[] {1, -1},
        new int[] {0, -1},
        new int[] {-1, -1}
        };

        int m = board.Length;
        int n = board[0].Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Maintaining a counter of live cells in the original matrix
                int liveCount = 0;

                foreach (int[] direction in directions)
                {
                    // Determining what our new row would be after taking a direction
                    int nr = i + direction[0];

                    // Determining what our new column would be after taking a direction
                    int nc = j + direction[1];

                    // Ensuring that our new_row and new_column
                    // are within the bounds of the matrix
                    if (nr >= 0 && nr < m && nc >= 0 && nc < n && Math.Abs(board[nr][nc]) == 1)
                    {
                        int value = board[nr][nc];
                        liveCount++;
                    }
                }

                if (board[i][j] == 1)
                {
                    // case where live cell dies from under/over population
                    if (liveCount < 2 || liveCount > 3)
                    {
                        board[i][j] = -1;
                    }
                }
                else
                {
                    // case of dead cell resurrection
                    if (liveCount == 3)
                    {
                        board[i][j] = 2;
                    }
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == -1)
                {
                    board[i][j] = 0;
                }
                else if (board[i][j] == 2)
                {
                    board[i][j] = 1;
                }
            }
        }
        
    }
}