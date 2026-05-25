namespace LeetCodeSave.GraphsDFS;

public class ReorderRoutestoMakeAllPathsLeadtotheCityZero //45
{
    public int MinReorder(int n, int[][] connections) {
        HashSet<(int a, int b)> directions = [];
        Dictionary<int, List<int>> graph = [];

        for(int i = 0; i < n; i++) {
            graph[i] = [];
        }

        foreach(var edge in connections) {
            int x = edge[0];
            int y = edge[1];

            graph[x].Add(y);
            graph[y].Add(x);

            directions.Add((x,y));
        }

        Stack<int> stack = [];
        HashSet<int> visited = [];
        int turns = 0;

        stack.Push(0);
        visited.Add(0);

        while(stack.Count > 0) {
            int v = stack.Pop();

            foreach(var neigh in graph[v]) {
                if(!visited.Contains(neigh)) {

                    if(directions.Contains((v, neigh))) {
                        turns++;
                    }

                    stack.Push(neigh);
                    visited.Add(neigh);
                }
            }

        }

        return turns;
    }
}