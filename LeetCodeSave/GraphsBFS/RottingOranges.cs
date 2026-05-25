namespace LeetCodeSave.GraphsBFS;

public class RottingOranges //48
{
    public int OrangesRotting(int[][] grid) {
        int minute = 0, good=0;
        Queue<(int i, int j)> q = new Queue<(int i, int j)>();
        for(int i=0; i<grid.Length; i++)
        {
            for(int j=0; j<grid[0].Length; j++)
            {
                if(grid[i][j] == 2)
                    q.Enqueue((i,j));
                if(grid[i][j] == 1)
                    good++;
            }
        }
        q.Enqueue((-1,-1));
        while(q.Count > 1)
        {
            var cell = q.Dequeue();
            if(cell.i == -1)
            {
                minute++;
                q.Enqueue((-1,-1));
                continue;
            }
            if(cell.i > 0 && grid[cell.i-1][cell.j] == 1)
            {
                q.Enqueue((cell.i-1,cell.j));
                grid[cell.i-1][cell.j] = 2;
                good--;
            }
            if(cell.j > 0 && grid[cell.i][cell.j-1] == 1)
            {
                q.Enqueue((cell.i,cell.j-1));
                grid[cell.i][cell.j-1] = 2;
                good--;
            }
            if(cell.i < grid.Length-1 && grid[cell.i+1][cell.j] == 1)
            {
                q.Enqueue((cell.i+1,cell.j));
                grid[cell.i+1][cell.j] = 2;
                good--;
            }
            if(cell.j < grid[0].Length-1 && grid[cell.i][cell.j+1] == 1)
            {
                q.Enqueue((cell.i,cell.j+1));
                grid[cell.i][cell.j+1] = 2;
                good--;
            }
        }

        return (good == 0)? minute : -1;
    }
}