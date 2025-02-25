
namespace LeetCode
{
    public class Solution23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;

            // Priority queue with a custom comparer to order by ListNode values
            var pq = new SortedSet<ListNode>(Comparer<ListNode>.Create((a, b) => {
                if (a.val != b.val) return a.val.CompareTo(b.val);
                return a.GetHashCode().CompareTo(b.GetHashCode());
            }));

            // Add the head of each non-null list to the priority queue
            foreach (var list in lists)
            {
                if (list != null)
                {
                    pq.Add(list);
                }
            }

            // Dummy node to help construct the merged list
            var dummy = new ListNode(-1);
            var current = dummy;

            // Build the merged list by extracting the smallest element and adding the next node
            while (pq.Count > 0)
            {
                var smallest = pq.Min;
                pq.Remove(smallest);

                current.next = smallest;
                current = current.next;

                if (smallest.next != null)
                {
                    pq.Add(smallest.next);
                }
            }

            return dummy.next;
        }
    }
}
