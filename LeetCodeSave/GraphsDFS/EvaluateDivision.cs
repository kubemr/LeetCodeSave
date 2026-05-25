namespace LeetCodeSave.GraphsDFS;

public class EvaluateDivision //46
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = new Dictionary<string, Dictionary<string, double>>();
        
        for (int i = 0; i < equations.Count; i++)
        {
            string a = equations[i][0], b = equations[i][1];
            if (!graph.ContainsKey(a)) graph[a] = new Dictionary<string, double>();
            if (!graph.ContainsKey(b)) graph[b] = new Dictionary<string, double>();
            graph[a][b] = values[i];
            graph[b][a] = 1 / values[i];
        }
        
        double DFS(string start, string end, ISet<string> visited)
        {
            if (!graph.ContainsKey(start) || !visited.Add(start)) 
                return -1;
            if (start == end) 
                return 1;
            foreach (var neighbor in graph[start])
            {
                double product = DFS(neighbor.Key, end, visited);
                if (product > 0) 
                    return neighbor.Value * product;
            }
            return -1;
        }
        
        var results = new double[queries.Count];
        for (int i = 0; i < queries.Count; i++)
        {
            string a = queries[i][0], b = queries[i][1];
            results[i] = DFS(a, b, new HashSet<string>());
        }

        return results;
    }
}