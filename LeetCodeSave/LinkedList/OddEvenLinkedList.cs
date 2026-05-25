namespace LeetCodeSave.LinkedList;

public class OddEvenLinkedList
{
    //30 Odd Even Linked List
    public static ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null) return head;
        ListNode odd = new ListNode(0);
        ListNode oddPtr = odd;
        ListNode even = new ListNode(0);
        ListNode evenPtr = even;
        int idx = 1;
        while(head != null){
            if(idx % 2 == 0){
                evenPtr.next = head;
                evenPtr = evenPtr.next;
            }else{
                oddPtr.next = head;
                oddPtr = oddPtr.next;
            }
            head = head.next;
            idx++;
        }
        evenPtr.next = null;
        oddPtr.next = even.next; 
        return odd.next;
    }
}