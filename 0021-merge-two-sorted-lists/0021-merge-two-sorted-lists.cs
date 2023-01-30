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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        //둘 중 하나가 null이면 그 반대의 값을 return 시켜준다.
        if(l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode l3 = new ListNode(0);
        ListNode curr = l3;

        while(l1 != null && l2 != null)
        {
            //오름차순 정렬을 위해 작은 값을 curr.next에 넣어주고 l1 or l2를 다음 값으로 증가 시킨다.
            //curr에 curr의 다음값을 넣는다.
            if(l1.val <= l2.val)
            {
                curr.next = l1;
                l1 = l1.next;
            }
            else
            {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }

        curr.next = l1 == null ? l2 : l1;
        return l3.next;
    }
}
