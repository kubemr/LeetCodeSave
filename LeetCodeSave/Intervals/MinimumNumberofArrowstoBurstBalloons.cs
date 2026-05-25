namespace LeetCodeSave.Intervals;

public class MinimumNumberofArrowstoBurstBalloons //73
{
    public int FindMinArrowShots(int[][] points) {
        
        var sortedDict = new PriorityQueue<int[], int>();

        for (var i = 0; i < points.Length; i++)
            sortedDict.Enqueue(points[i], points[i][0]);

        var counter = 0;
        var n = sortedDict.Count;
        for (int i = 0; i < n; i++) {

            if(!sortedDict.TryDequeue(out var element, out _)) continue;
            if(!sortedDict.TryPeek(out var element1, out _)) {counter++; continue;};
            
            if(element1[0] >= element[0] && element1[0] <= element[1]) {
                
                sortedDict.Dequeue();
                element[1] = Math.Min(element[1], element1[1]);
                sortedDict.Enqueue(element, element[0]);
            }
            else counter++;
        }
        return sortedDict.Count + counter;
    }
}