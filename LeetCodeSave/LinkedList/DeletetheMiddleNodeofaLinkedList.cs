using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.LinkedList
{
    public class DeletetheMiddleNodeofaLinkedList
    {
        // 29 Delete the Middle Node of a Linked List
        public static ListNode DeleteMiddle(ListNode head) {
            if(head == null)return null;
            ListNode prev = new ListNode(0);
            prev.next = head;
            ListNode slow = prev;
            ListNode fast = head;
            while(fast != null && fast.next != null){
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return prev.next;
        }
    }
}
