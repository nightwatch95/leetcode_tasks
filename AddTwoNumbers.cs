/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int temp = 0;
        ListNode result = new ListNode(0);
        ListNode cur = result;
        
        while (l1 != null || l2 != null)
        {
            int x = l1 != null ? l1.val : 0;
            int y = l2 != null ? l2.val : 0;
            
            temp += x + y;
            if (temp >= 10)
            {
                cur = new ListNode(temp % 10);
                temp = temp / 10;
            }
            else
            {
                cur = new ListNode(temp);
                temp = 0;
            }
            
            cur = cur.next;
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        
        if (temp > 0)
        {
            cur = new ListNode(temp);
        }
        
        return (result);
    }
}