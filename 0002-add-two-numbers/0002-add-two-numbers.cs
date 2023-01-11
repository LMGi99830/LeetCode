/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        ListNode answer = l3;
        int count = 0;

        while(l1 != null || l2 != null || count != 0)
        {
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;
            int Sum = v1 + v2 + count;
            count = Sum / 10;
            
            answer.next = new ListNode(Sum % 10);
            answer = answer.next;

            if(l1 != null)
            {
                l1 = l1.next;
            }
            if ( l2 != null )
            {
                l2 = l2.next;
            }
        }
        return l3.next;
    }
}