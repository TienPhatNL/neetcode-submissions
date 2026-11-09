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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode lNode = null, fNode = null, prev = null, kNode = null, result = null;
        ListNode current = head;
        int pos = 1;
        int swNodes = right - left + 1;
        
        while(current != null){
            if(left == 1){
                lNode = null;
                kNode = current;
                fNode = current;

                while(swNodes > 0){
                    ListNode temp = kNode.next;
                    kNode.next = prev;
                    prev = kNode;
                    kNode = temp;
                    swNodes--;
                }

                fNode.next = kNode;

                result = prev;
                break;
            }
            if(pos == left - 1){
                lNode = current;
                kNode = current.next;
                fNode = current.next;

                while(swNodes > 0){
                    ListNode temp = kNode.next;
                    kNode.next = prev;
                    prev = kNode;
                    kNode = temp;
                    swNodes--;
                }

                lNode.next = prev;
                fNode.next = kNode;

                result = head;
                break;
            }
            
            pos++;
            current = current.next;
        }
        return result;
    }
}