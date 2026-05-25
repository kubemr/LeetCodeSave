namespace LeetCodeSave.GraphsBFS;

public class NearestExitfromEntranceinMaze //47
{
    public int NearestExit(char[][] maze, int[] entrance) {
        int m = maze.Length;
        int n = maze[0].Length;
        
        int[][] directions = new int[][] {
            [-1, 0],
            [1, 0],
            [0, -1],
            [0, 1]
        };
        
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((entrance[0], entrance[1], 0)); 
        maze[entrance[0]][entrance[1]] = '+'; 
        
        while (queue.Count > 0) {
            var (x, y, steps) = queue.Dequeue();
            
            foreach (var dir in directions) {
                int newX = x + dir[0];
                int newY = y + dir[1];
                
                if (newX >= 0 && newX < m && newY >= 0 && newY < n && maze[newX][newY] == '.') {
                    if (newX == 0 || newX == m - 1 || newY == 0 || newY == n - 1) {
                        return steps + 1;
                    }
                    
                    maze[newX][newY] = '+';
                    queue.Enqueue((newX, newY, steps + 1));
                }
            }
        }
        
        return -1;
    }
}