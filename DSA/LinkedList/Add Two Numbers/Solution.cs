// LeetCode 2. Add Two Numbers
// Original implementation by the author.

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultNodes = null;
        ListNode CurrentNodel1 = l1;
        ListNode CurrentNodel2 = l2;
        ListNode CurrentNode = null;
        int carry = 0;

        while (true)
        {
            if (CurrentNode == null)
            {
                CurrentNode = new ListNode();
            }
            else
            {
                CurrentNode.next = new ListNode();
                CurrentNode = CurrentNode.next;
            }

            CurrentNode.val = carry;

            if (CurrentNodel1 != null)
            {
                CurrentNode.val += CurrentNodel1.val;
            }

            if (CurrentNodel2 != null)
            {
                CurrentNode.val += CurrentNodel2.val;
            }

            if (CurrentNode.val > 9)
            {
                carry = CurrentNode.val / 10;
                CurrentNode.val = CurrentNode.val % 10;
            }
            else
            {
                carry = 0;
            }

            if (resultNodes == null)
            {
                resultNodes = CurrentNode;
            }

            if (CurrentNodel1 != null)
            {
                CurrentNodel1 = CurrentNodel1.next;
            }

            if (CurrentNodel2 != null)
            {
                CurrentNodel2 = CurrentNodel2.next;
            }

            if (CurrentNodel1 == null && CurrentNodel2 == null && carry == 0)
            {
                break;
            }
        }

        return resultNodes;
    }
}
