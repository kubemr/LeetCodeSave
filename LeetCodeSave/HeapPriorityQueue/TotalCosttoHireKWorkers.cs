namespace LeetCodeSave.HeapPriorityQueue;

public class TotalCosttoHireKWorkers //52
{
    public long TotalCost(int[] costs, int k, int candidates) {
        
        PriorityQueue<int,int> minHeap1 = new PriorityQueue<int,int>();
        PriorityQueue<int,int> minHeap2 = new PriorityQueue<int,int>();

        int i = 0, j = costs.Length - 1;
        long totalCost = 0;
        while(k > 0)
        {
            while(minHeap1.Count < candidates && i <= j)
            {
                minHeap1.Enqueue(costs[i], costs[i]);
                i++;
            }

            while(minHeap2.Count < candidates && i <= j)
            {
                minHeap2.Enqueue(costs[j], costs[j]);
                j--;
            }

            int cost1 = minHeap1.Count == 0? Int32.MaxValue : minHeap1.Peek();
            int cost2 = minHeap2.Count == 0? Int32.MaxValue : minHeap2.Peek();
            if(cost1 <= cost2)
            {
                minHeap1.TryDequeue(out int minCost, out int minPriority);
                totalCost += minCost;
            }
            else
            {
                minHeap2.TryDequeue(out int minCost, out int minPriority);
                totalCost += minCost;
            }

            k--;
        }

        return totalCost;
    }
}