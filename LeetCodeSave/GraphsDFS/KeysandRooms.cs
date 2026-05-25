namespace LeetCodeSave.GraphsDFS;

public class KeysandRooms //43
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var seen = new HashSet<int>();
        seen.Add(0);
        var queue = new Queue<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            var roomId = queue.Dequeue();
            foreach (var key in rooms[roomId])
            {
                if (!seen.Contains(key))
                {
                    seen.Add(key);
                    queue.Enqueue(key);
                }
            }
        }

        return seen.Count == rooms.Count;
    }
}